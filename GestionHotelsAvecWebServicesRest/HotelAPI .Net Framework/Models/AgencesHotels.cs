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
        [Column(Order = 1)]
        public int AgenceId { get; set; }
        [ForeignKey("AgenceId")]
        public virtual Agence Agence { get; set; }
        
        [Key]
        [Column(Order = 2)]
        public int HotelId { get; set; }
        [ForeignKey("HotelId")]
        public virtual Hotel Hotel { get; set; }

    }
}
