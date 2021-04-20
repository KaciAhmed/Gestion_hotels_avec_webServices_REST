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
        [Key]
        public int HotelId { get; set; }
        public string Nom { get; set; }
        public int NbEtoile { get; set; }
        public virtual Adresse Adresse { get ; set; }
        public virtual ICollection<Chambre> Chambres { get; set; }
        public virtual ICollection<Agence> AgencesHotels { get ; set; }

        public Hotel()
        {
            this.Chambres = new List<Chambre>();
            this.AgencesHotels = new List<Agence>();
        }
    }
}
