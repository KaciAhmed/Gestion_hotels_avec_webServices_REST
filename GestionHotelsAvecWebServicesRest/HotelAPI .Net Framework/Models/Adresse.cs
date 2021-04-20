using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionHotelsAvecWebServicesRest.Models
{
    public class Adresse
    {
        public int AdresseId { get; set; }
        public int Numero { get; set; }
        public string Rue { get; set; }
        public string Pays { get; set; }
        public string PositionGPS { get; set; }
        public string LieuDit { get; set; }
        public ICollection<Hotel> Hotels { get; set; }
        public ICollection<Agence> Agences { get; set; }
        public Adresse()
        {
            this.Hotels = new List<Hotel>();
            this.Agences = new List<Agence>();
        }
    }
}

