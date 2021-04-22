namespace HotelRest.Migrations
{
    using HotelRest.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HotelRest.Data.HotelRestContext>
    {
        private const string CHEMIN_DOSSIER_ASSETS = @"C:\Users\DELL\source\repos\gestionHotelsAvecRest\gestionhotelsavecwebservicesrest\assets";
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HotelRest.Data.HotelRestContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
    
            Adresse a1 = new Adresse() { AdresseId = 1, Numero = 54, Rue = "Rue Agence 1", Pays = "France", PositionGPS = "43.6N, 3.9E", LieuDit = "Lieu dit Agence 1" };
            Adresse a2 = new Adresse() { AdresseId = 2, Numero = 22, Rue = "Rue Agence 2", Pays = "France", PositionGPS = "43.6N, 3.9E", LieuDit = "Lieu dit Agence 2" };
            Adresse a3 = new Adresse() { AdresseId = 3, Numero = 67, Rue = "Rue Agence 3", Pays = "France", PositionGPS = "43.6N, 3.9E", LieuDit = "Lieu dit Agence 3" };
            Adresse a4 = new Adresse() { AdresseId = 4, Numero = 123, Rue = "Rue Hotel 1", Pays = "France", PositionGPS = "43.6N, 3.9E", LieuDit = "Lieu dit Hotel 1" };
            Adresse a5 = new Adresse() { AdresseId = 5, Numero = 213, Rue = "Rue Hotel 2", Pays = "France", PositionGPS = "43.6N, 3.9E", LieuDit = "Lieu dit Hotel 2" };
            Adresse a6 = new Adresse() { AdresseId = 6, Numero = 312, Rue = "Rue Hotel 3", Pays = "France", PositionGPS = "43.6N, 3.9E", LieuDit = "Lieu dit Hotel 3" };

            Client c1 = new Client() { ClientId = 1, Nom = "Allouch", Prenom = "Yanis" };
            Client c2 = new Client() { ClientId = 2, Nom = "Kaci", Prenom = "Ahmed" };

            Agence ag1 = new Agence() { AgenceId = 1, Nom = "Kshlerin-Breitenberg", Login = "LoginAgence1", MotDePasse = "123", PourcentageReduction = 0.09 };
            Agence ag2 = new Agence() { AgenceId = 2, Nom = "Bashirian, Goyette and Denesik", Login = "LoginAgence2", MotDePasse = "123", PourcentageReduction = 0.32 };
            Agence ag3 = new Agence() { AgenceId = 3, Nom = "Hyatt-Corwin", Login = "LoginAgence3", MotDePasse = "123", PourcentageReduction = 0.27 };

            Hotel h1 = new Hotel() { HotelId= 1, Nom = "Hotel 1", NbEtoile = 5 };
            Hotel h2 = new Hotel() { HotelId =2, Nom = "Hotel 2", NbEtoile = 4 };
            Hotel h3 = new Hotel() { HotelId =3, Nom = "Hotel 3", NbEtoile = 3 };

            TypeChambre t1 = new TypeChambre() { TypeChambreId=1, NbLits = 1 };
            TypeChambre t2 = new TypeChambre() { TypeChambreId=2, NbLits = 2 };
            TypeChambre t3 = new TypeChambre() { TypeChambreId=3, NbLits = 3 };

            // Hotel 1
            Chambre ch1 = new Chambre() { ChambreId = 1, Numero = 1, EstLibre = true, DateDisponibilite = "01/03/2021", PrixDeBase = 51, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png", TypeChambre= t1,Hotel= h1 };
            Chambre ch2 = new Chambre() { ChambreId = 2, Numero = 15, EstLibre = true, DateDisponibilite = "10/03/2021", PrixDeBase = 41, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png", TypeChambre = t1, Hotel = h1 };
            Chambre ch3 = new Chambre() { ChambreId = 3, Numero = 12, EstLibre = true, DateDisponibilite = "10/04/2021", PrixDeBase = 69, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png", TypeChambre = t1, Hotel = h1 };
            Chambre ch4 = new Chambre() { ChambreId = 4, Numero = 22, EstLibre = true, DateDisponibilite = "02/03/2021", PrixDeBase = 50, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png", TypeChambre = t2, Hotel = h1 };
            Chambre ch5 = new Chambre() { ChambreId = 5, Numero = 25, EstLibre = true, DateDisponibilite = "20/03/2021", PrixDeBase = 79, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png", TypeChambre = t2, Hotel = h1 };
            Chambre ch6 = new Chambre() { ChambreId = 6, Numero = 28, EstLibre = true, DateDisponibilite = "02/04/2021", PrixDeBase = 38, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png", TypeChambre = t2, Hotel = h1 };
            Chambre ch7 = new Chambre() { ChambreId = 7, Numero = 32, EstLibre = true, DateDisponibilite = "02/03/2021", PrixDeBase = 69, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png", TypeChambre = t3, Hotel = h1 };
            Chambre ch8 = new Chambre() { ChambreId = 8, Numero = 35, EstLibre = true, DateDisponibilite = "18/03/2021", PrixDeBase = 57, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png", TypeChambre = t3, Hotel = h1 };
            Chambre ch9 = new Chambre() { ChambreId = 9, Numero = 38, EstLibre = true, DateDisponibilite = "31/03/2021", PrixDeBase = 82, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png", TypeChambre = t3, Hotel = h1 };
            // Hotel 2
            Chambre ch10 = new Chambre() { ChambreId = 10, Numero = 1, EstLibre = true, DateDisponibilite = "01/03/2021", PrixDeBase = 51, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png", TypeChambre = t1, Hotel = h2 };
            Chambre ch11 = new Chambre() { ChambreId = 11, Numero = 15, EstLibre = true, DateDisponibilite = "10/03/2021", PrixDeBase = 41, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png", TypeChambre = t1, Hotel = h2 };
            Chambre ch12 = new Chambre() { ChambreId = 12, Numero = 12, EstLibre = true, DateDisponibilite = "10/04/2021", PrixDeBase = 69, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png", TypeChambre = t1, Hotel = h2 };
            Chambre ch13 = new Chambre() { ChambreId = 13, Numero = 22, EstLibre = true, DateDisponibilite = "02/03/2021", PrixDeBase = 50, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png", TypeChambre = t2, Hotel = h2 };
            Chambre ch14 = new Chambre() { ChambreId = 14, Numero = 25, EstLibre = true, DateDisponibilite = "20/03/2021", PrixDeBase = 79, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png", TypeChambre = t2, Hotel = h2 };
            Chambre ch15 = new Chambre() { ChambreId = 15, Numero = 28, EstLibre = true, DateDisponibilite = "02/04/2021", PrixDeBase = 38, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png", TypeChambre = t2, Hotel = h2 };
            Chambre ch16 = new Chambre() { ChambreId = 16, Numero = 32, EstLibre = true, DateDisponibilite = "02/03/2021", PrixDeBase = 69, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png", TypeChambre = t3, Hotel = h2 };
            Chambre ch17 = new Chambre() { ChambreId = 17, Numero = 35, EstLibre = true, DateDisponibilite = "18/03/2021", PrixDeBase = 57, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png", TypeChambre = t3, Hotel = h2 };
            Chambre ch18 = new Chambre() { ChambreId = 18, Numero = 38, EstLibre = true, DateDisponibilite = "31/03/2021", PrixDeBase = 82, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png", TypeChambre = t3, Hotel = h2 };
            // Hotel 3
            Chambre ch19 = new Chambre() { ChambreId = 19, Numero = 1, EstLibre = true, DateDisponibilite = "01/03/2021", PrixDeBase = 51, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png", TypeChambre = t1, Hotel = h3 };
            Chambre ch21 = new Chambre() { ChambreId = 21, Numero = 15, EstLibre = true, DateDisponibilite = "10/03/2021", PrixDeBase = 41, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png", TypeChambre = t1, Hotel = h3 };
            Chambre ch22 = new Chambre() { ChambreId = 22, Numero = 12, EstLibre = true, DateDisponibilite = "10/04/2021", PrixDeBase = 69, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png", TypeChambre = t1, Hotel = h3 };
            Chambre ch23 = new Chambre() { ChambreId = 23, Numero = 22, EstLibre = true, DateDisponibilite = "02/03/2021", PrixDeBase = 50, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png", TypeChambre = t2, Hotel = h3 };
            Chambre ch24 = new Chambre() { ChambreId = 24, Numero = 25, EstLibre = true, DateDisponibilite = "20/03/2021", PrixDeBase = 79, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png", TypeChambre = t2, Hotel = h3 };
            Chambre ch25 = new Chambre() { ChambreId = 25, Numero = 28, EstLibre = true, DateDisponibilite = "02/04/2021", PrixDeBase = 38, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png", TypeChambre = t2, Hotel = h3 };
            Chambre ch20 = new Chambre() { ChambreId = 20, Numero = 38, EstLibre = true, DateDisponibilite = "31/03/2021", PrixDeBase = 82, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png", TypeChambre = t3, Hotel = h3 };
            Chambre ch26 = new Chambre() { ChambreId = 26, Numero = 32, EstLibre = true, DateDisponibilite = "02/03/2021", PrixDeBase = 69, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png", TypeChambre = t3, Hotel = h3 };
            Chambre ch27 = new Chambre() { ChambreId = 27, Numero = 35, EstLibre = true, DateDisponibilite = "18/03/2021", PrixDeBase = 57, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png", TypeChambre = t3, Hotel = h3 };


            Reservation r1 = new Reservation() { ReservationId = 1, Reference = "#79744", DateDebut = "02/01/2021", DateFin = "04/01/2021", NbPersonne = 2, InformationCarteCredit = "4716533460348581",Client= c1, Agence= ag1,Chambre= ch5 };
            Reservation r2 = new Reservation() { ReservationId = 2, Reference = "#79744", DateDebut = "02/02/2021", DateFin = "04/02/2021", NbPersonne = 2, InformationCarteCredit = "4716533460348581", Client = c2,Agence= ag1,Chambre= ch5 };

            a1.Agence = ag1;
            a2.Agence = ag2;
            a3.Agence = ag3;
            a4.Hotel = h1;
            a5.Hotel = h2;
            a6.Hotel = h3;

            ag1.Adresse = a1;
            ag2.Adresse = a2;
            ag3.Adresse = a3;
            h1.Adresse = a4;
            h2.Adresse = a5;
            h3.Adresse = a6;

            ICollection<Chambre> cht1 = new List<Chambre>() { ch1, ch2, ch3, ch10, ch11, ch12, ch19, ch21, ch22 };
            ICollection<Chambre> cht2 = new List<Chambre>() { ch4, ch5, ch6, ch13, ch14, ch15, ch23, ch24, ch25 };
            ICollection<Chambre> cht3 = new List<Chambre>() { ch7, ch8, ch9, ch16, ch17, ch18, ch20, ch26, ch27 };

            t1.Chambres = cht1;
            t2.Chambres = cht2;
            t3.Chambres = cht3;

            ICollection<Chambre> chambreHotel1 = new List<Chambre>() { ch1, ch2, ch3, ch4, ch5, ch6, ch7, ch8, ch9 };
            ICollection<Chambre> chambreHotel2 = new List<Chambre>() { ch10, ch11, ch12, ch13, ch14, ch15, ch16, ch17, ch18 };
            ICollection<Chambre> chambreHotel3 = new List<Chambre>() { ch19, ch21, ch22, ch23, ch24, ch25, ch20, ch26, ch27 };

            h1.Chambres = chambreHotel1;
            h2.Chambres = chambreHotel2;
            h3.Chambres = chambreHotel3;

            ICollection<Agence> agencesHotel1 = new List<Agence>() { ag1, ag2, ag3 };
            ICollection<Agence> agencesHotel2 = new List<Agence>() { ag1, ag2, ag3 };
            ICollection<Agence> agencesHotel3 = new List<Agence>() { ag1, ag2, ag3 };

            h1.AgencesHotels = agencesHotel1;
            h2.AgencesHotels = agencesHotel2;
            h3.AgencesHotels = agencesHotel3;

            ICollection<Hotel> hotelsAgence1 = new List<Hotel>() { h1, h2, h3 };
            ICollection<Hotel> hotelsAgence2 = new List<Hotel>() { h1, h2, h3 };
            ICollection<Hotel> hotelsAgence3 = new List<Hotel>() { h1, h2, h3 };

            ag1.Hotels = hotelsAgence1;
            ag2.Hotels = hotelsAgence2;
            ag3.Hotels = hotelsAgence3;

            c1.Reservations.Add(r1);
            c2.Reservations.Add(r2);

            ag1.Reservations.Add(r1);
            ag1.Reservations.Add(r2);

            ch5.Reservations.Add(r1);
            ch5.Reservations.Add(r2);

            context.TypeChambres.AddOrUpdate(new TypeChambre[] { t1, t2, t3 });
            context.Adresses.AddOrUpdate(new Adresse[] { a1, a2, a3, a4, a5, a6 });
            context.Clients.AddOrUpdate(new Client[] { c1, c2 });
            context.Agences.AddOrUpdate(new Agence[] { ag1, ag2, ag3 });
            context.Hotels.AddOrUpdate(new Hotel[] { h1, h2, h3 });
            context.Chambres.AddOrUpdate(new Chambre[] { ch1, ch2, ch3, ch4, ch5, ch6, ch7, ch8, ch9, ch10, ch11, ch12, ch13, ch14, ch15, ch16, ch17, ch18, ch19, ch20, ch21, ch22, ch23, ch24, ch25, ch26, ch27 });
            context.Reservations.AddOrUpdate(new Reservation[] { r1, r2 });
        }
    }
}
