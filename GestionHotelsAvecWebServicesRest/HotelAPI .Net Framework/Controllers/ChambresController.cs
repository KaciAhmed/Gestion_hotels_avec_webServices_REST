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
    public class ChambresController : ApiController
    {
        private HotelAPINet_FrameworkContext db = new HotelAPINet_FrameworkContext();

        // GET: api/Chambres
        public IQueryable<Chambre> GetChambres()
        {
            return db.Chambres;
        }

        // GET: api/Chambres/5
        [ResponseType(typeof(Chambre))]
        public async Task<IHttpActionResult> GetChambre(int id)
        {
            Chambre chambre = await db.Chambres.FindAsync(id);
            if (chambre == null)
            {
                return NotFound();
            }

            return Ok(chambre);
        }

        // PUT: api/Chambres/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutChambre(int id, Chambre chambre)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != chambre.ChambreId)
            {
                return BadRequest();
            }

            db.Entry(chambre).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChambreExists(id))
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

        // POST: api/Chambres
        [ResponseType(typeof(Chambre))]
        public async Task<IHttpActionResult> PostChambre(Chambre chambre)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Chambres.Add(chambre);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = chambre.ChambreId }, chambre);
        }

        // DELETE: api/Chambres/5
        [ResponseType(typeof(Chambre))]
        public async Task<IHttpActionResult> DeleteChambre(int id)
        {
            Chambre chambre = await db.Chambres.FindAsync(id);
            if (chambre == null)
            {
                return NotFound();
            }

            db.Chambres.Remove(chambre);
            await db.SaveChangesAsync();

            return Ok(chambre);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ChambreExists(int id)
        {
            return db.Chambres.Count(e => e.ChambreId == id) > 0;
        }
    }
}