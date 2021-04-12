using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionHotelsAvecWebServicesRest.Models
{
    public class Client
    {
        private int identifiant;
        private string nom;
        private string prenom;


        public Client()
        {
        }

        public Client(int identifiant, string nom, string prenom, List<Reservation> historiqueReservations)
        {
            this.identifiant = identifiant;
            this.nom = nom;
            this.prenom = prenom;
        }
        public Client(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }
        public int Identifiant { get => identifiant; set => identifiant = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
    }
}
