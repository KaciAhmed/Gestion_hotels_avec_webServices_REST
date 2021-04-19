using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionHotelsAvecWebServicesRest.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }
        private string Nom { get; set; }
        private int NbEtoile { get; set; }
        public int AdresseId { get; set; }

        /// <summary>
        /// La FK suivante est utilisé pour référencer par proprièté de cette classe "AdresseId"qui contient alors un identifiant dans la BDD d'une adresse, soit la FK.
        /// Pour l'instancier comme Adresse dans cette classe par la propriété Adresse.
        /// </summary>

        [ForeignKey("AdresseId")] 
        public virtual Adresse Adresse { get ; set; }
        public virtual ICollection<Chambre> Chambres { get; set; }
        public virtual ICollection<AgencesHotels> AgencesHotels { get ; set; }

        public Hotel()
        {
            this.Chambres = new List<Chambre>();
            this.AgencesHotels = new List<AgencesHotels>();
        }
    }
}
