namespace Agence
{
    internal class Reservation
    {
        public int ReservationId { get; set; }
        public string Reference { get; set; }
        public string DateDebut { get; set; }
        public string DateFin { get; set; }
        public int NbPersonne { get; set; }
        public string InformationCarteCredit { get; set; }
        public string Client { get; set; }
        public string Agence { get; set; }
        public string Chambre { get; set; }
        public Reservation()
        {
        }

        public Reservation(int reservationId, string reference, string dateDebut, string dateFin, int nbPersonne, string informationCarteCredit, string client, string agence, string chambre)
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