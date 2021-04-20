using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionHotelsAvecWebServicesRest.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public virtual Agence Agence { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public Client()
        {
            this.Reservations = new List<Reservation>();
        }
    }
}
