using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionHotelsAvecWebServicesRest.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        public string Reference { get; set; }
        public string DateDebut { get; set; }
        public string DateFin { get; set; }
        public int NbPersonne { get; set; }
        public string InformationCarteCredit { get; set; }
        public virtual Client Client { get; set; }        
        public virtual Agence Agence { get; set; }
        public virtual Chambre Chambre { get; set; }
        public Reservation()
        { 
        }
    }
}
