using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelRest.Models
{
    public class Agence
    {
        public int AgenceId { get; set; }
        public string Nom { get; set; }
        public string Login { get; set; }
        public string MotDePasse { get; set; }
        public double PourcentageReduction { get; set; }
        public virtual Adresse Adresse { get; set; }
        public ICollection<Hotel> Hotels { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
      
       
        public Agence()
        {
            this.Reservations = new List<Reservation>();
 
            this.Hotels = new List<Hotel>();
        }

        public Agence(int agenceId, string nom, string login, string motDePasse, double pourcentageReduction, Adresse adresse, ICollection<Hotel> hotels, ICollection<Reservation> reservations)
        {
            AgenceId = agenceId;
            Nom = nom;
            Login = login;
            MotDePasse = motDePasse;
            PourcentageReduction = pourcentageReduction;
            Adresse = adresse;
            Hotels = hotels;
            Reservations = reservations;
        }
    }
}