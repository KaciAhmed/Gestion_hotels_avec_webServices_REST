using HotelRest.Data;
using HotelRest.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;


namespace HotelRest.Controllers
{
    [RoutePrefix("api/hotels")]
    public class HotelsController : ApiController
    {
        private HotelRestContext db = new HotelRestContext();
        private Agence monAgenceEnTraitement;
        private static MaDatabase database = new MaDatabase();

        // GET: api/Hotel
        [ResponseType(typeof(Hotel))]
        public IQueryable<Hotel> GetHotel()
        {
            return database.Hotels.AsQueryable<Hotel>().Where(hotel => 1 == hotel.HotelId);
        }

        // GET: api/Hotel/Offres/{login}/{password}/{nbPersonne}
        [Route("offres/{loginAgence}/{mdp}/{dateDebut}/{dateFin}/{nbPersonne}")]
        public IQueryable<Offre> GetOffres(string loginAgence, string mdp, string dateDebut, string dateFin, string nbPersonne)
        {
            bool checkConnexion = false;
            IQueryable<Offre> offres = null;
            checkConnexion = verifierConnexionAgence(loginAgence, mdp);
            if (checkConnexion)
            {
                List<Chambre> chambresDisponible = getChambresDisponible(dateDebut, int.Parse(nbPersonne));
                offres = creerOffres(chambresDisponible);
            }
            return offres;
        }

        [HttpGet]
        [Route("reservation")]
        public string GetReservation(string loginAgence, string mdp, string identifiant, string dateArrivee, string dateDepart, int nombrePersonnes, string nomClient, string prenomClient, string infoCarteCreditClient)
        {
            var random = new Random();
            var reservationId = database.Reservations.Last().ReservationId + 1;

            var agence = database.Agences.Where(ag => ag.Login == loginAgence && ag.MotDePasse == mdp).First();

            var chambreId = int.Parse(identifiant.Split('_')[1]);
            var chambre = database.Chambres.Where(c => c.ChambreId == chambreId).First();

            var clientId = database.Clients.Last().ClientId + 1;
            var client = new Client() { ClientId = clientId, Nom = nomClient, Prenom = prenomClient };

            var reservation = new Reservation()
            {
                ReservationId = (reservationId),
                Agence = agence,
                DateDebut = dateArrivee,
                DateFin = dateDepart,
                InformationCarteCredit = infoCarteCreditClient,
                NbPersonne = nombrePersonnes,
                Reference = "#" + random.Next(1000, 10000),
                Chambre = chambre,
                Client = client,
            };

            database.Reservations.Add(reservation);

            database.Clients.Add(client);

            var res = new List<Reservation>();
            res.Add(reservation);


            return reservation.Reference.ToString();
        }

        private bool verifierConnexionAgence(string login, string mdp)
        {
            List<Agence> agences = new List<Agence>(database.Agences);

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
            List<Chambre> chambres = new List<Chambre>(database.Chambres);

            List<Chambre> chambresDisponible = new List<Chambre>();
            foreach (Chambre chambre in chambres)
            {
                dateDisponibilte = DateTime.ParseExact(chambre.DateDisponibilite, "dd-MM-yyyy", new CultureInfo("fr-FR", false));
                if (DateTime.Compare(dateDisponibilte, dateDebutTemp) <= 0 && chambre.TypeChambre.NbLits == nbPersonne && chambre.EstLibre)
                {
                    chambresDisponible.Add(chambre);
                }
            }
            return chambresDisponible;
        }
        private IQueryable<Offre> creerOffres(List<Chambre> chambres)
        {
            ICollection<Offre> offres = new List<Offre>();
            Offre offre = null;
            double prix;
            int idHotel = 1;
            foreach (Chambre chambre in chambres)
            {
                prix = chambre.PrixDeBase * (1 - monAgenceEnTraitement.PourcentageReduction);
                offre = new Offre() { Identifiant = idHotel + "_" + chambre.Numero, TypeChambre = chambre.TypeChambre, DateDisponibilite = chambre.DateDisponibilite, Prix = prix };
                offres.Add(offre);
            }
            return offres.AsQueryable<Offre>();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}