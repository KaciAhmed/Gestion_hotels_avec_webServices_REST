namespace HotelRest.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public string Reference { get; set; }
        public string DateDebut { get; set; }
        public string DateFin { get; set; }
        public int NbPersonne { get; set; }
        public string InformationCarteCredit { get; set; }
        public Client Client { get; set; }
        public Agence Agence { get; set; }
        public Chambre Chambre { get; set; }
        public Reservation()
        {
        }

        public Reservation(int reservationId, string reference, string dateDebut, string dateFin, int nbPersonne, string informationCarteCredit, Client client, Agence agence, Chambre chambre)
        {
            ReservationId = reservationId;
            Reference = reference;
            DateDebut = dateDebut;
            DateFin = dateFin;
            NbPersonne = nbPersonne;
            InformationCarteCredit = informationCarteCredit;
            Client = client;
            Agence = agence;
            Chambre = chambre;
        }
    }
}