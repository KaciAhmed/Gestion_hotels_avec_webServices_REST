using HotelRest.Models;
using System.Collections.Generic;

namespace HotelRest.Controllers
{
    public class MaDatabase
    {
        private const string CHEMIN_DOSSIER_ASSETS = @"C:\Users\DELL\source\repos\gestionHotelsAvecRest\gestionhotelsavecwebservicesrest\assets\";

        public ICollection<Adresse> Adresses { get; set; }
        public ICollection<Client> Clients { get; set; }
        public ICollection<Agence> Agences { get; set; }
        public ICollection<Hotel> Hotels { get; set; }
        public ICollection<TypeChambre> TypeChambres { get; set; }
        public ICollection<Chambre> Chambres { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public MaDatabase()
        {
            // Initialisation des tables
            Adresses = new List<Adresse>();
            Clients = new List<Client>();
            Agences = new List<Agence>();
            Hotels = new List<Hotel>();
            TypeChambres = new List<TypeChambre>();
            Chambres = new List<Chambre>();
            Reservations = new List<Reservation>();

            Adresse a1 = new Adresse() { AdresseId = 1, Numero = 54, Rue = "Rue Agence 1", Pays = "France", PositionGPS = "43.6N, 3.9E", LieuDit = "Lieu dit Agence 1" };
            Adresse a2 = new Adresse() { AdresseId = 2, Numero = 22, Rue = "Rue Agence 2", Pays = "France", PositionGPS = "43.6N, 3.9E", LieuDit = "Lieu dit Agence 2" };
            Adresse a3 = new Adresse() { AdresseId = 3, Numero = 67, Rue = "Rue Agence 3", Pays = "France", PositionGPS = "43.6N, 3.9E", LieuDit = "Lieu dit Agence 3" };
            Adresse a4 = new Adresse() { AdresseId = 4, Numero = 123, Rue = "Rue Hotel 1", Pays = "France", PositionGPS = "43.6N, 3.9E", LieuDit = "Lieu dit Hotel 1" };
            Adresse a5 = new Adresse() { AdresseId = 5, Numero = 213, Rue = "Rue Hotel 2", Pays = "France", PositionGPS = "43.6N, 3.9E", LieuDit = "Lieu dit Hotel 2" };
            Adresse a6 = new Adresse() { AdresseId = 6, Numero = 312, Rue = "Rue Hotel 3", Pays = "France", PositionGPS = "43.6N, 3.9E", LieuDit = "Lieu dit Hotel 3" };

            Adresses.Add(a1);
            Adresses.Add(a2);
            Adresses.Add(a3);
            Adresses.Add(a4);
            Adresses.Add(a5);
            Adresses.Add(a6);

            Client c1 = new Client() { ClientId = 1, Nom = "Allouch", Prenom = "Yanis" };
            Client c2 = new Client() { ClientId = 2, Nom = "Kaci", Prenom = "Ahmed" };

            Clients.Add(c1);
            Clients.Add(c2);

            Agence ag1 = new Agence() { AgenceId = 1, Nom = "Kshlerin-Breitenberg", Login = "LoginAgence1", MotDePasse = "123", PourcentageReduction = 0.09 };
            Agence ag2 = new Agence() { AgenceId = 2, Nom = "Bashirian, Goyette and Denesik", Login = "LoginAgence2", MotDePasse = "123", PourcentageReduction = 0.32 };
            Agence ag3 = new Agence() { AgenceId = 3, Nom = "Hyatt-Corwin", Login = "LoginAgence3", MotDePasse = "123", PourcentageReduction = 0.27 };

            Agences.Add(ag1);
            Agences.Add(ag2);
            Agences.Add(ag3);

            Hotel h1 = new Hotel() { HotelId = 1, Nom = "Hotel 1", NbEtoile = 5 };

            Hotels.Add(h1);

            TypeChambre t1 = new TypeChambre() { TypeChambreId = 1, NbLits = 1 };
            TypeChambre t2 = new TypeChambre() { TypeChambreId = 2, NbLits = 2 };
            TypeChambre t3 = new TypeChambre() { TypeChambreId = 3, NbLits = 3 };

            TypeChambres.Add(t1);
            TypeChambres.Add(t2);
            TypeChambres.Add(t3);

            // Hotel 1
            Chambre ch1 = new Chambre() { ChambreId = 1, Numero = 1, EstLibre = true, DateDisponibilite = "01-03-2021", PrixDeBase = 51, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png", TypeChambre = t1 };
            Chambre ch2 = new Chambre() { ChambreId = 2, Numero = 15, EstLibre = true, DateDisponibilite = "10-03-2021", PrixDeBase = 41, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png", TypeChambre = t1 };
            Chambre ch3 = new Chambre() { ChambreId = 3, Numero = 12, EstLibre = true, DateDisponibilite = "10-04-2021", PrixDeBase = 69, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png", TypeChambre = t1 };
            Chambre ch4 = new Chambre() { ChambreId = 4, Numero = 22, EstLibre = true, DateDisponibilite = "02-03-2021", PrixDeBase = 50, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png", TypeChambre = t2 };
            Chambre ch5 = new Chambre() { ChambreId = 5, Numero = 25, EstLibre = true, DateDisponibilite = "20-03-2021", PrixDeBase = 79, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png", TypeChambre = t2 };
            Chambre ch6 = new Chambre() { ChambreId = 6, Numero = 28, EstLibre = true, DateDisponibilite = "02-04-2021", PrixDeBase = 38, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png", TypeChambre = t2 };
            Chambre ch7 = new Chambre() { ChambreId = 7, Numero = 32, EstLibre = true, DateDisponibilite = "02-03-2021", PrixDeBase = 69, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png", TypeChambre = t3 };
            Chambre ch8 = new Chambre() { ChambreId = 8, Numero = 35, EstLibre = true, DateDisponibilite = "18-03-2021", PrixDeBase = 57, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png", TypeChambre = t3 };
            Chambre ch9 = new Chambre() { ChambreId = 9, Numero = 38, EstLibre = true, DateDisponibilite = "31-03-2021", PrixDeBase = 82, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png", TypeChambre = t3 };

            Chambres.Add(ch1);
            Chambres.Add(ch2);
            Chambres.Add(ch3);
            Chambres.Add(ch4);
            Chambres.Add(ch5);
            Chambres.Add(ch6);
            Chambres.Add(ch7);
            Chambres.Add(ch8);
            Chambres.Add(ch9);

            Reservation r1 = new Reservation() { ReservationId = 1, Reference = "#79744", DateDebut = "02-01-2021", DateFin = "04-01-2021", NbPersonne = 2, InformationCarteCredit = "4716533460348581", Client = c1, Agence = ag1, Chambre = ch5 };
            Reservation r2 = new Reservation() { ReservationId = 2, Reference = "#79744", DateDebut = "02-02-2021", DateFin = "04-02-2021", NbPersonne = 2, InformationCarteCredit = "4716533460348581", Client = c2, Agence = ag1, Chambre = ch5 };

            Reservations.Add(r1);
            Reservations.Add(r2);

            ag1.Adresse = a1;
            ag2.Adresse = a2;
            ag3.Adresse = a3;
            h1.Adresse = a4;

            ICollection<Chambre> chambreHotel1 = new List<Chambre>() { ch1, ch2, ch3, ch4, ch5, ch6, ch7, ch8, ch9 };

            h1.Chambres = chambreHotel1;

            ICollection<Agence> agencesHotel1 = new List<Agence>() { ag1, ag2, ag3 };
            ICollection<Agence> agencesHotel2 = new List<Agence>() { ag1, ag2, ag3 };
            ICollection<Agence> agencesHotel3 = new List<Agence>() { ag1, ag2, ag3 };

            h1.AgencesHotels = agencesHotel1;
        }
    }
}