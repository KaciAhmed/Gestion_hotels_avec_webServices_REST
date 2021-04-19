namespace HotelAPI.Net_Framework.Migrations
{
    using GestionHotelsAvecWebServicesRest.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HotelAPI.Net_Framework.Data.HotelAPINet_FrameworkContext>
    {
        private const string CHEMIN_DOSSIER_ASSETS = @"E:\gitlab.com\gestionhotelsavecwebservicesrest\GestionHotelsAvecWebServicesRest\assets\";

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HotelAPI.Net_Framework.Data.HotelAPINet_FrameworkContext context)
        {
            context.TypeChambres.AddOrUpdate(new TypeChambre[] {
                new TypeChambre() { TypeChambreId = 1, NbLits = 1},
                new TypeChambre() { TypeChambreId = 2, NbLits = 2},
                new TypeChambre() { TypeChambreId = 3, NbLits = 3}
                });

            context.Adresses.AddOrUpdate(new Adresse[] {
                new Adresse() { AdresseId = 1, Numero = 54, Rue = "Rue Agence 1", Pays = "France", PositionGPS = "43.6°N, 3.9°E", LieuDit = "Lieu dit Agence 1" },
                new Adresse() { AdresseId = 2, Numero = 22, Rue = "Rue Agence 2", Pays = "France", PositionGPS = "43.6°N, 3.9°E", LieuDit = "Lieu dit Agence 2" },
                new Adresse() { AdresseId = 3, Numero = 67, Rue = "Rue Agence 3", Pays = "France", PositionGPS = "43.6°N, 3.9°E", LieuDit = "Lieu dit Agence 3" },
                new Adresse() { AdresseId = 4, Numero = 123, Rue = "Rue Hotel 1", Pays = "France", PositionGPS = "43.6°N, 3.9°E", LieuDit = "Lieu dit Hotel 1" },
                new Adresse() { AdresseId = 5, Numero = 213, Rue = "Rue Hotel 2", Pays = "France", PositionGPS = "43.6°N, 3.9°E", LieuDit = "Lieu dit Hotel 2" },
                new Adresse() { AdresseId = 6, Numero = 312, Rue = "Rue Hotel 3", Pays = "France", PositionGPS = "43.6°N, 3.9°E", LieuDit = "Lieu dit Hotel 3" }
                });

            context.Clients.AddOrUpdate(new Client[] {
                new Client() { ClientId = 1, Nom = "Allouch", Prenom = "Yanis"},
                new Client() { ClientId = 2, Nom = "Kaci", Prenom = "Ahmed"}
                });

            context.Agences.AddOrUpdate(new Agence[] {
                new Agence() { AgenceId = 1, Nom = "Kshlerin-Breitenberg", Login = "LoginAgence1", MotDePasse = "123", PourcentageReduction = 0.09, AdresseId = 1 },
                new Agence() { AgenceId = 2, Nom = "Bashirian, Goyette and Denesik", Login = "LoginAgence2", MotDePasse = "123", PourcentageReduction = 0.32, AdresseId = 2 },
                new Agence() { AgenceId = 3, Nom = "Hyatt-Corwin", Login = "LoginAgence3", MotDePasse = "123", PourcentageReduction = 0.27, AdresseId = 3 }
                });

            context.Hotels.AddOrUpdate(new Hotel[] {
                new Hotel() { HotelId = 1, Nom = "Hotel 1", NbEtoile = 5, AdresseId = 4},
                new Hotel() { HotelId = 2, Nom = "Hotel 2", NbEtoile = 4, AdresseId = 5},
                new Hotel() { HotelId = 3, Nom = "Hotel 3", NbEtoile = 3, AdresseId = 6}
                });

            context.Chambres.AddOrUpdate(new Chambre[] {
                // Hotel 1
                new Chambre() { ChambreId = 1,  Numero = 1, EstLibre = true, DateDisponibilite = "01/03/2021", PrixDeBase = 51, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png", TypeChambreId = 1, HotelId = 1 },
                new Chambre() { ChambreId = 2,  Numero = 15, EstLibre = true, DateDisponibilite = "10/03/2021", PrixDeBase = 41, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png", TypeChambreId = 1, HotelId = 1 },
                new Chambre() { ChambreId = 3,  Numero = 12, EstLibre = true, DateDisponibilite = "10/04/2021", PrixDeBase = 69, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png", TypeChambreId = 1, HotelId = 1 },
                new Chambre() { ChambreId = 4,  Numero = 22, EstLibre = true, DateDisponibilite = "02/03/2021", PrixDeBase = 50, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png", TypeChambreId = 2, HotelId = 1 },
                new Chambre() { ChambreId = 5,  Numero = 25, EstLibre = true, DateDisponibilite = "20/03/2021", PrixDeBase = 79, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png", TypeChambreId = 2, HotelId = 1 },
                new Chambre() { ChambreId = 6,  Numero = 28, EstLibre = true, DateDisponibilite = "02/04/2021", PrixDeBase = 38, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png", TypeChambreId = 2, HotelId = 1 },
                new Chambre() { ChambreId = 7,  Numero = 32, EstLibre = true, DateDisponibilite = "02/03/2021", PrixDeBase = 69, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png", TypeChambreId = 3, HotelId = 1 },
                new Chambre() { ChambreId = 8,  Numero = 35, EstLibre = true, DateDisponibilite = "18/03/2021", PrixDeBase = 57, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png", TypeChambreId = 3, HotelId = 1 },
                new Chambre() { ChambreId = 9,  Numero = 38, EstLibre = true, DateDisponibilite = "31/03/2021", PrixDeBase = 82, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png", TypeChambreId = 3, HotelId = 1 },
                // Hotel 2
                new Chambre() { ChambreId = 10,  Numero = 1, EstLibre = true, DateDisponibilite = "01/03/2021", PrixDeBase = 51, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png", TypeChambreId = 1, HotelId = 2 },
                new Chambre() { ChambreId = 11,  Numero = 15, EstLibre = true, DateDisponibilite = "10/03/2021", PrixDeBase = 41, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png", TypeChambreId = 1, HotelId = 2 },
                new Chambre() { ChambreId = 12,  Numero = 12, EstLibre = true, DateDisponibilite = "10/04/2021", PrixDeBase = 69, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png", TypeChambreId = 1, HotelId = 2 },
                new Chambre() { ChambreId = 13,  Numero = 22, EstLibre = true, DateDisponibilite = "02/03/2021", PrixDeBase = 50, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png", TypeChambreId = 2, HotelId = 2 },
                new Chambre() { ChambreId = 14,  Numero = 25, EstLibre = true, DateDisponibilite = "20/03/2021", PrixDeBase = 79, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png", TypeChambreId = 2, HotelId = 2 },
                new Chambre() { ChambreId = 15,  Numero = 28, EstLibre = true, DateDisponibilite = "02/04/2021", PrixDeBase = 38, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png", TypeChambreId = 2, HotelId = 2 },
                new Chambre() { ChambreId = 16,  Numero = 32, EstLibre = true, DateDisponibilite = "02/03/2021", PrixDeBase = 69, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png", TypeChambreId = 3, HotelId = 2 },
                new Chambre() { ChambreId = 17,  Numero = 35, EstLibre = true, DateDisponibilite = "18/03/2021", PrixDeBase = 57, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png", TypeChambreId = 3, HotelId = 2 },
                new Chambre() { ChambreId = 18,  Numero = 38, EstLibre = true, DateDisponibilite = "31/03/2021", PrixDeBase = 82, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png", TypeChambreId = 3, HotelId = 2 },
                // Hotel 3
                new Chambre() { ChambreId = 19,  Numero = 1, EstLibre = true, DateDisponibilite = "01/03/2021", PrixDeBase = 51, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png", TypeChambreId = 1, HotelId = 3 },
                new Chambre() { ChambreId = 20,  Numero = 38, EstLibre = true, DateDisponibilite = "31/03/2021", PrixDeBase = 82, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png", TypeChambreId = 3, HotelId = 3 },
                new Chambre() { ChambreId = 21,  Numero = 15, EstLibre = true, DateDisponibilite = "10/03/2021", PrixDeBase = 41, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png", TypeChambreId = 1, HotelId = 3 },
                new Chambre() { ChambreId = 22,  Numero = 12, EstLibre = true, DateDisponibilite = "10/04/2021", PrixDeBase = 69, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png", TypeChambreId = 1, HotelId = 3 },
                new Chambre() { ChambreId = 23,  Numero = 22, EstLibre = true, DateDisponibilite = "02/03/2021", PrixDeBase = 50, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png", TypeChambreId = 2, HotelId = 3 },
                new Chambre() { ChambreId = 24,  Numero = 25, EstLibre = true, DateDisponibilite = "20/03/2021", PrixDeBase = 79, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png", TypeChambreId = 2, HotelId = 3 },
                new Chambre() { ChambreId = 25,  Numero = 28, EstLibre = true, DateDisponibilite = "02/04/2021", PrixDeBase = 38, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png", TypeChambreId = 2, HotelId = 3 },
                new Chambre() { ChambreId = 26,  Numero = 32, EstLibre = true, DateDisponibilite = "02/03/2021", PrixDeBase = 69, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png", TypeChambreId = 3, HotelId = 3 },
                new Chambre() { ChambreId = 27,  Numero = 35, EstLibre = true, DateDisponibilite = "18/03/2021", PrixDeBase = 57, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png", TypeChambreId = 3, HotelId = 3 },
            });

            context.Reservations.AddOrUpdate(new Reservation[] {
                new Reservation() { ReservationId = 1, Reference = "#79744", DateDebut = "02/01/2021", DateFin = "04/01/2021", NbPersonne = 2, InformationCarteCredit = "4716533460348581", ClientId = 1, AgenceId = 1, ChambreId = 5 },
                new Reservation() { ReservationId = 1, Reference = "#79744", DateDebut = "02/02/2021", DateFin = "04/02/2021", NbPersonne = 2, InformationCarteCredit = "4716533460348581", ClientId = 2, AgenceId = 1, ChambreId = 5 }
                });

            context.AgencesHotels.AddOrUpdate(new AgencesHotels[] {
                new AgencesHotels() { AgenceId = 1, HotelId = 1},
                new AgencesHotels() { AgenceId = 2, HotelId = 1},
                new AgencesHotels() { AgenceId = 2, HotelId = 2},
                new AgencesHotels() { AgenceId = 3, HotelId = 3}
                });
        }
    }
}
