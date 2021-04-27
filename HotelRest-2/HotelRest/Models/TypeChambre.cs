using System.Collections.Generic;

namespace HotelRest.Models
{
    public class TypeChambre
    {
        public int TypeChambreId { get; set; }
        public int NbLits { get; set; }
        public ICollection<Chambre> Chambres { get; set; }

        public TypeChambre()
        {
            Chambres = new List<Chambre>();
        }

        public TypeChambre(int typeChambreId, int nbLits, ICollection<Chambre> chambres)
        {
            TypeChambreId = typeChambreId;
            NbLits = nbLits;
            Chambres = chambres;
        }
    }
}