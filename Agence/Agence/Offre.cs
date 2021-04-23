using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    class Offre
    {
       
        public string Identifiant { get ; set; }
        public string TypeChambre { get; set; }
        public string DateDisponibilite { get; set; }
        public double Prix { get; set; }
        public byte[] Image { get; set; }

        public Offre()
        {
        }

        public Offre(string identifiant, string typeChambre, string dateDisponibilite, double prix, byte[] image)
        {
            Identifiant = identifiant;
            TypeChambre = typeChambre;
            DateDisponibilite = dateDisponibilite;
            Prix = prix;
            Image = image;
        }

        public override string ToString()
        {
            return Identifiant + "," + TypeChambre + "," + DateDisponibilite + "," + Prix + "," + Image;
        }
    }
}
