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
        public int ReservationId { get; set; }
        public string Reference { get; set; }
        public string DateDebut { get; set; }
        public string DateFin { get; set; }
        public int NbPersonne { get; set; }
        public string InformationCarteCredit { get; set; }
        
        /// <summary>
        /// La FK suivante est utilisé pour référencer par proprièté de cette classe "ClientId"qui contient alors un identifiant dans la BDD d'un client, soit la FK.
        /// Pour l'instancier comme Client dans cette classe par la propriété Client.
        /// </summary>
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }
        
        public int AgenceId { get; set; }
        [ForeignKey("AgenceId")]
        public virtual Agence Agence { get; set; }
        
        public int ChambreId { get; set; }
        [ForeignKey("ChambreId")]
        public virtual Chambre Chambre { get; set; }
        public Reservation()
        { 
        }
    }
}
