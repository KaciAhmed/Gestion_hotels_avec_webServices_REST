using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HotelRest.Models
{
    public class Hotel
    {
        [ForeignKey("Adresse")]
        public int HotelId { get; set; }
        public string Nom { get; set; }
        public int NbEtoile { get; set; }
        public virtual Adresse Adresse { get; set; }
        public  ICollection<Chambre> Chambres { get; set; }
        public  ICollection<Agence> AgencesHotels { get; set; }

        public Hotel()
        {
            this.Chambres = new List<Chambre>();
            this.AgencesHotels = new List<Agence>();
        }

        public Hotel(int hotelId, string nom, int nbEtoile, Adresse adresse, ICollection<Chambre> chambres, ICollection<Agence> agencesHotels)
        {
            HotelId = hotelId;
            Nom = nom;
            NbEtoile = nbEtoile;
            Adresse = adresse;
            Chambres = chambres;
            AgencesHotels = agencesHotels;
        }
    }
}