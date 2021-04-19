using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionHotelsAvecWebServicesRest.Models
{
    public class Adresse
    {
        private int id;
        private int numero;
        private string rue;
        private string pays;
        private string positionGPS;
        private string lieuDit;
        public Adresse()
        {
        }

        public Adresse(int id, int numero, string rue, string pays, string positionGPS, string lieuDit)
        {
            this.id = id;
            this.numero = numero;
            this.rue = rue;
            this.pays = pays;
            this.positionGPS = positionGPS;
            this.lieuDit = lieuDit;
        }

        public int AdresseId { get => id; set => id = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Rue { get => rue; set => rue = value; }
        public string Pays { get => pays; set => pays = value; }
        public string PositionGPS { get => positionGPS; set => positionGPS = value; }
        public string LieuDit { get => lieuDit; set => lieuDit = value; }
    }
}

