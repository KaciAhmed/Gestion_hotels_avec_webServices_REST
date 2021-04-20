using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionHotelsAvecWebServicesRest.Models
{
    public class TypeChambre
    {
        [Key]
        public int TypeChambreId { get; set; }
        public int NbLits { get; set; }
    }
}
