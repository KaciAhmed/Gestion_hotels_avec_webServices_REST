using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionHotelsAvecWebServicesRest.Models
{
    public class TypeChambre
    {
        private int id;
        private int nbLit;

        public TypeChambre()
        {
        }

        public TypeChambre(int id, int nbLit)
        {
            this.id = id;
            this.nbLit = nbLit;
        }

        public int TypeChambreId { get => id; set => id = value; }
        public int NbLits { get => nbLit; set => nbLit = value; }

        public override string ToString()
        {
            return TypeChambreId.ToString()+" "+NbLits.ToString();
        }
    }
}
