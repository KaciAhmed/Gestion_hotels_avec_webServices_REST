using HotelRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelRest
{
    public class Offre
    {
        public string Identifiant { get; set; }
        public TypeChambre TypeChambre { get; set; }
        public string DateDisponibilite { get; set; }
        public double Prix { get; set; }
        public byte[] Image { get; set; }

        public Offre()
        {
        }

        public Offre(string identifiant, TypeChambre typeChambre, string dateDisponibilite, double prix, byte[] image)
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