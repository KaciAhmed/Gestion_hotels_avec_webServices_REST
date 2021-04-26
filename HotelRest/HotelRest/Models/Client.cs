using System.Collections.Generic;

namespace HotelRest.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public Client()
        {
            Reservations = new List<Reservation>();
        }

        public Client(int clientId, string nom, string prenom, ICollection<Reservation> reservations)
        {
            ClientId = clientId;
            Nom = nom;
            Prenom = prenom;
            Reservations = reservations;
        }
    }
}