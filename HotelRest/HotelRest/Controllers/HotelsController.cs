using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Globalization;
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
    [RoutePrefix("api/Hotels")]
    public class HotelsController : ApiController
    {
        private HotelRestContext db = new HotelRestContext();
        private Agence monAgenceEnTraitement;

        // GET: api/Hotels
        public IQueryable<Hotel> GetHotels()
        {
            return db.Hotels;
        }

        // GET: api/Hotels/5
        [ResponseType(typeof(Hotel))]
        public async Task<IHttpActionResult> GetHotel(int id)
        {
            Hotel hotel = await db.Hotels.FindAsync(id);
            if (hotel == null)
            {
                return NotFound();
            }

            return Ok(hotel);
        }

        // PUT: api/Hotels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutHotel(int id, Hotel hotel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hotel.HotelId)
            {
                return BadRequest();
            }

            db.Entry(hotel).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelExists(id))
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

        // POST: api/Hotels
        [ResponseType(typeof(Hotel))]
        public async Task<IHttpActionResult> PostHotel(Hotel hotel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Hotels.Add(hotel);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HotelExists(hotel.HotelId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = hotel.HotelId }, hotel);
        }

        // DELETE: api/Hotels/5
        [ResponseType(typeof(Hotel))]
        public async Task<IHttpActionResult> DeleteHotel(int id)
        {
            Hotel hotel = await db.Hotels.FindAsync(id);
            if (hotel == null)
            {
                return NotFound();
            }

            db.Hotels.Remove(hotel);
            await db.SaveChangesAsync();

            return Ok(hotel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HotelExists(int id)
        {
            return db.Hotels.Count(e => e.HotelId == id) > 0;
        }


        // GET: api/Hotels/Offres/{login}/{password}/{}
        [Route("offres/{LoginAgence}/{mdp}/{dateDebut}/{dateFin}/{nbPersonne}")]
        public string GetOffres(string LoginAgence,string mdp,string dateDebut,string dateFin,string nbPersonne)
        {
            bool checkConnexion = false;
            string offres = "";
            checkConnexion = verifierConnexionAgence(LoginAgence, mdp);
            if (checkConnexion)
            {
                List <Chambre>chambresDisponible= getChambresDisponible(dateDebut, int.Parse(nbPersonne));
                offres =creerOffres(chambresDisponible);
            }
            return offres;
           
        }
        private bool verifierConnexionAgence(string login, string mdp)
        {
            List<Agence> agences = new List<Agence>(db.Agences);

            foreach (Agence agence in agences)
            {
               if (login.Equals(agence.Login) && mdp.Equals(agence.MotDePasse))
                {
                    monAgenceEnTraitement = agence;
                    return true;
                }
            }
            return false;
        }
       private List<Chambre> getChambresDisponible(String dateDebut, int nbPersonne)
        {
            DateTime dateDebutTemp = DateTime.ParseExact(dateDebut, "dd-MM-yyyy", new CultureInfo("fr-FR", false));
            DateTime dateDisponibilte;
            List<Chambre> chambres = new List<Chambre>(db.Chambres);
           
            List<Chambre> chambresDisponible = new List<Chambre>();
            foreach (Chambre chambre in chambres)
            {
                // à corriger
                chambre.TypeChambre = new TypeChambre(1, 1, new List<Chambre>());
                dateDisponibilte = DateTime.ParseExact(chambre.DateDisponibilite, "dd-MM-yyyy", new CultureInfo("fr-FR", false));
                if (DateTime.Compare(dateDisponibilte, dateDebutTemp) <= 0 && chambre.TypeChambre.NbLits == nbPersonne && chambre.EstLibre)
                {
                    chambresDisponible.Add(chambre);
                }
            }
            return chambresDisponible;
        }
        private string creerOffres(List<Chambre> chambres)
        {
            string offres=null;
            double prix;
            int idHotel = 1;
            foreach (Chambre chambre in chambres)
            {
                 prix =chambre.PrixDeBase * (1 - monAgenceEnTraitement.PourcentageReduction);
                if (offres == null)
                {
                    offres = idHotel + "_" + chambre.Numero + "," + chambre.TypeChambre.NbLits + "," + chambre.DateDisponibilite + "," + prix + "||";
                }
                else
                {
                    offres += idHotel + "_" + chambre.Numero + "," + chambre.TypeChambre.NbLits + "," + chambre.DateDisponibilite + "," + prix+ "||";
                }

            }
            return offres;
        }
    }
}