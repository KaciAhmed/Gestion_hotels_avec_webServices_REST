using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionHotelsAvecWebServicesRest.Models
{
    public class Hotel
    {
        private int identifiant;
        private string nom;
        private int nbEtoile;
        private Adresse adresse;
        private List<Chambre> chambres;
        private List<AgencesHotels> agencesHotel;

        public Hotel()
        {
            chambres = new List<Chambre>();
            agencesHotel = new List<AgencesHotels>();
        }
        public Hotel(int identifiant, string nom, int nbEtoile, Adresse adresse, List<Chambre> chambres, List<AgencesHotels> agencesHotel)
        {
            this.identifiant = identifiant;
            this.nom = nom;
            this.nbEtoile = nbEtoile;
            this.adresse = adresse;
            this.chambres = chambres;
            this.agencesHotel = agencesHotel;
        }
        public Hotel(int identifiant, string nom, int nbEtoile, Adresse adresse)
        {
            this.identifiant = identifiant;
            this.nom = nom;
            this.nbEtoile = nbEtoile;
            this.adresse = adresse;
            chambres = new List<Chambre>();
            agencesHotel = new List<AgencesHotels>();

        }
        public int HotelId { get => identifiant; set => identifiant = value; }
        private string Nom { get => nom; set => nom = value; }
        private int NbEtoile { get => nbEtoile; set => nbEtoile = value; }
        [ForeignKey("AdresseId")]
        public Adresse Adresse { get => adresse; set => adresse = value; }
        public List<Chambre> Chambres { get => chambres; set => chambres = value; }
        public List<AgencesHotels> AgencesHotel { get => agencesHotel; set => agencesHotel = value; }
    }
}
