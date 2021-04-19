using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using GestionHotelsAvecWebServicesRest.Models;
using HotelAPI.Net_Framework.Data;

namespace HotelAPI.Net_Framework.Controllers
{
    public class AgencesHotelsController : ApiController
    {
        private HotelAPINet_FrameworkContext db = new HotelAPINet_FrameworkContext();

        // GET: api/AgencesHotels
        public IQueryable<AgencesHotels> GetAgencesHotels()
        {
            return db.AgencesHotels;
        }

        // GET: api/AgencesHotels/5
        [ResponseType(typeof(AgencesHotels))]
        public async Task<IHttpActionResult> GetAgencesHotels(int id)
        {
            AgencesHotels agencesHotels = await db.AgencesHotels.FindAsync(id);
            if (agencesHotels == null)
            {
                return NotFound();
            }

            return Ok(agencesHotels);
        }

        // PUT: api/AgencesHotels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAgencesHotels(int id, AgencesHotels agencesHotels)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != agencesHotels.AgenceId)
            {
                return BadRequest();
            }

            db.Entry(agencesHotels).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgencesHotelsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/AgencesHotels
        [ResponseType(typeof(AgencesHotels))]
        public async Task<IHttpActionResult> PostAgencesHotels(AgencesHotels agencesHotels)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AgencesHotels.Add(agencesHotels);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AgencesHotelsExists(agencesHotels.AgenceId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = agencesHotels.AgenceId }, agencesHotels);
        }

        // DELETE: api/AgencesHotels/5
        [ResponseType(typeof(AgencesHotels))]
        public async Task<IHttpActionResult> DeleteAgencesHotels(int id)
        {
            AgencesHotels agencesHotels = await db.AgencesHotels.FindAsync(id);
            if (agencesHotels == null)
            {
                return NotFound();
            }

            db.AgencesHotels.Remove(agencesHotels);
            await db.SaveChangesAsync();

            return Ok(agencesHotels);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AgencesHotelsExists(int id)
        {
            return db.AgencesHotels.Count(e => e.AgenceId == id) > 0;
        }
    }
}