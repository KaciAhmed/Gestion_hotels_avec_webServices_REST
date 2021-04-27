using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AgenceApi2.Controllers
{
    [RoutePrefix("api/agences")]
    public class AgenceController : ApiController
    {
        private readonly static string nomAgence = "Agence 2 Confluence";
        private readonly static string LoginAgence = "LoginAgence2";
        private readonly static string mdp = "123";
        private static ClientRest clientRest = new ClientRest();
        private Dictionary<string, List<string>> hotelsPartenaires = new Dictionary<string, List<string>>() {
            { @"https://localhost:44365/api/Hotels/", new List<string>() { "Montpellier", "5" } },
            { @"https://localhost:44366/api/Hotels/", new List<string>() { "Montpellier", "5" } }

        };
        private List<string> baseUrlHotelsChoisis;

        [Route("name")]
        public string GetName()
        {
            return nomAgence;
        }

        // GET: api/Hotel/Offres/{login}/{password}/{nbPersonne}
        [Route("offres/{ville}/{dateDebut}/{dateFin}/{nbPersonne}/{nombreEtoile}")]
        public IQueryable<OffreComparateur> GetOffres(string ville, string dateDebut, string dateFin, string nbPersonne, int nombreEtoile)
        {

            List<OffreComparateur> offres;
            baseUrlHotelsChoisis = new List<string>();

            string route;
            foreach (KeyValuePair<string, List<string>> hotel in hotelsPartenaires)
            {
                if (hotel.Value[0].Equals(ville.Trim()) && (hotel.Value[1].CompareTo(nombreEtoile.ToString()) >= 0))
                {
                    baseUrlHotelsChoisis.Add(hotel.Key);
                }
            }
            offres = new List<OffreComparateur>();
            route = "offresComparateur" + "/" + LoginAgence + "/" + mdp + "/" + dateDebut + "/" + dateFin + "/" + nbPersonne;

            foreach (string baseUrlHotel in baseUrlHotelsChoisis)
            {
                offres.AddRange(clientRest.makeRequestGetOffresComparateur(baseUrlHotel, route));
            }
            foreach (OffreComparateur o in offres)
            {
                o.AgenceNom = nomAgence;
            }
            return offres.AsQueryable();
        }
    }
}

