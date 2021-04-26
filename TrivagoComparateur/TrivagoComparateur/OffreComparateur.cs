namespace TrivagoComparateur
{
    internal class OffreComparateur
    {
        public string AgenceNom { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public int NombreEtoile { get; set; }
        public int NombreLit { get; set; }
        public double Prix { get; set; }

        public override string ToString()
        {
            return "{\n"
                + AgenceNom
                + ", "
                + "Nom: " + Nom + ",Adresse: " + Adresse + ", NombreEtoile: " + NombreEtoile + ", Prix: " + Prix
                + "\n}";
        }
    }
}
