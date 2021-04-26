using HotelRest.Data;
using HotelRest.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace HotelRest.Controllers
{
    public class AdressesController : ApiController
    {
        private HotelRestContext db = new HotelRestContext();

        // GET: api/Adresses
        public IQueryable<Adresse> GetAdresses()
        {
            return db.Adresses;
        }

        // GET: api/Adresses/5
        [ResponseType(typeof(Adresse))]
        public async Task<IHttpActionResult> GetAdresse(int id)
        {
            Adresse adresse = await db.Adresses.FindAsync(id);
            if (adresse == null)
            {
                return NotFound();
            }

            return Ok(adresse);
        }

        // PUT: api/Adresses/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAdresse(int id, Adresse adresse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != adresse.AdresseId)
            {
                return BadRequest();
            }

            db.Entry(adresse).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdresseExists(id))
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

        // POST: api/Adresses
        [ResponseType(typeof(Adresse))]
        public async Task<IHttpActionResult> PostAdresse(Adresse adresse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Adresses.Add(adresse);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = adresse.AdresseId }, adresse);
        }

        // DELETE: api/Adresses/5
        [ResponseType(typeof(Adresse))]
        public async Task<IHttpActionResult> DeleteAdresse(int id)
        {
            Adresse adresse = await db.Adresses.FindAsync(id);
            if (adresse == null)
            {
                return NotFound();
            }

            db.Adresses.Remove(adresse);
            await db.SaveChangesAsync();

            return Ok(adresse);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AdresseExists(int id)
        {
            return db.Adresses.Count(e => e.AdresseId == id) > 0;
        }
    }
}