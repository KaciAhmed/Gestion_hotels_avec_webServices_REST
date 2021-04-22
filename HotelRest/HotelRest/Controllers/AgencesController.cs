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
using HotelRest.Data;
using HotelRest.Models;

namespace HotelRest.Controllers
{
    public class AgencesController : ApiController
    {
        private HotelRestContext db = new HotelRestContext();

        // GET: api/Agences
        public IQueryable<Agence> GetAgences()
        {
            return db.Agences;
        }

        // GET: api/Agences/5
        [ResponseType(typeof(Agence))]
        public async Task<IHttpActionResult> GetAgence(int id)
        {
            Agence agence = await db.Agences.FindAsync(id);
            if (agence == null)
            {
                return NotFound();
            }

            return Ok(agence);
        }

        // PUT: api/Agences/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAgence(int id, Agence agence)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != agence.AgenceId)
            {
                return BadRequest();
            }

            db.Entry(agence).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgenceExists(id))
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

        // POST: api/Agences
        [ResponseType(typeof(Agence))]
        public async Task<IHttpActionResult> PostAgence(Agence agence)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Agences.Add(agence);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AgenceExists(agence.AgenceId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = agence.AgenceId }, agence);
        }

        // DELETE: api/Agences/5
        [ResponseType(typeof(Agence))]
        public async Task<IHttpActionResult> DeleteAgence(int id)
        {
            Agence agence = await db.Agences.FindAsync(id);
            if (agence == null)
            {
                return NotFound();
            }

            db.Agences.Remove(agence);
            await db.SaveChangesAsync();

            return Ok(agence);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AgenceExists(int id)
        {
            return db.Agences.Count(e => e.AgenceId == id) > 0;
        }
    }
}