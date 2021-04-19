using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionHotelsAvecWebServicesRest.Models
{
    public class AgencesHotels
    {
        [Key]
        [ForeignKey("AgenceId")]
        public Agence Agence { get; set; }
        [Key]
        [ForeignKey("HotelId")]
        public Hotel Hotel { get; set; }

        public AgencesHotels()
        {
        }
    }
}
