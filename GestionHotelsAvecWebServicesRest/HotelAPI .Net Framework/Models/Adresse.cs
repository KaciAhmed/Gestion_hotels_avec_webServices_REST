using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    }
}

