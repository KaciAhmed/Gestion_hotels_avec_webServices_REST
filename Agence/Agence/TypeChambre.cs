namespace Agence
{
    public class TypeChambre
    {
        public int TypeChambreId { get; set; }
        public int NbLits { get; set; }

        public TypeChambre()
        {
        }
        public TypeChambre(int typeChambreId, int nbLits)
        {
            TypeChambreId = typeChambreId;
            NbLits = nbLits;
        }

        public override string ToString()
        {
            return "NbLit = " + NbLits.ToString();
        }
    }
}