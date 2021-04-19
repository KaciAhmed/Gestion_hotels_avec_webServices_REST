using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionHotelsAvecWebServicesRest.Models
{
    public class TypeChambre
    {
        public int TypeChambreId { get; set; }
        public int NbLits { get; set; }

        public override string ToString()
        {
            return TypeChambreId.ToString() + " " + NbLits.ToString();
        }
    }
}
