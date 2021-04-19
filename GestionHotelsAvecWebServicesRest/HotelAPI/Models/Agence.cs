using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionHotelsAvecWebServicesRest.Models
{
    public class Agence
    {
        private int identifiant;
        private string nom;
        private string login;
        private string motDePAsse;
        private double pourcentageReduction;
        private Adresse adresse;
        private List<Reservation> reservations = new List<Reservation>();
        private List<Client> clients = new List<Client>();
        private List<AgencesHotels> hotelsAgence = new List<AgencesHotels>();
        public Agence()
        {
        }

        public Agence(int identifiant, string nom, string login, string motDePAsse, double pourcentageReduction, Adresse adresse,List<AgencesHotels> hotelsAgence, List<Reservation> historiqueReservations, List<Client> clients)
        {
            this.identifiant = identifiant;
            this.nom = nom;
            this.login = login;
            this.motDePAsse = motDePAsse;
            this.pourcentageReduction = pourcentageReduction;
            this.adresse = adresse;
            this.reservations = historiqueReservations;
            this.clients = clients;
            this.hotelsAgence = hotelsAgence;
        }


        public int AgenceId { get => identifiant; set => identifiant = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Login { get => login; set => login = value; }
        public string MotDePAsse { get => motDePAsse; set => motDePAsse = value; }
        public double PourcentageReduction { get => pourcentageReduction; set => pourcentageReduction = value; }
        [ForeignKey("AdresseId")]
        public Adresse Adresse { get => adresse; set => adresse = value; }
        public List<Reservation> Reservations { get => reservations; set => reservations = value; }
        public List<Client> Clients { get => clients; set => clients = value; }
        public List<AgencesHotels> HotelsAgence { get => hotelsAgence; set => hotelsAgence = value; }
    }
}

