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
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(HotelAPI.Net_Framework.Data.HotelAPINet_FrameworkContext context)
        {
            context.TypeChambres.AddOrUpdate(new TypeChambre[] {
                new TypeChambre() { NbLits = 1},
                new TypeChambre() { NbLits = 2},
                new TypeChambre() { NbLits = 3}
                });

            context.Adresses.AddOrUpdate(new Adresse[] {
                new Adresse() { Numero = 54, Rue = "Rue Agence 1", Pays = "France", PositionGPS = "43.6°N, 3.9°E", LieuDit = "Lieu dit Agence 1" },
                new Adresse() { Numero = 22, Rue = "Rue Agence 2", Pays = "France", PositionGPS = "43.6°N, 3.9°E", LieuDit = "Lieu dit Agence 2" },
                new Adresse() { Numero = 67, Rue = "Rue Agence 3", Pays = "France", PositionGPS = "43.6°N, 3.9°E", LieuDit = "Lieu dit Agence 3" },
                new Adresse() { Numero = 123, Rue = "Rue Hotel 1", Pays = "France", PositionGPS = "43.6°N, 3.9°E", LieuDit = "Lieu dit Hotel 1" },
                new Adresse() { Numero = 213, Rue = "Rue Hotel 2", Pays = "France", PositionGPS = "43.6°N, 3.9°E", LieuDit = "Lieu dit Hotel 2" },
                new Adresse() { Numero = 312, Rue = "Rue Hotel 3", Pays = "France", PositionGPS = "43.6°N, 3.9°E", LieuDit = "Lieu dit Hotel 3" }
                });

            context.Clients.AddOrUpdate(new Client[] {
                new Client() { Nom = "Allouch", Prenom = "Yanis"},
                new Client() { Nom = "Kaci", Prenom = "Ahmed"}
                });

            context.Agences.AddOrUpdate(new Agence[] {
                new Agence() { Nom = "Kshlerin-Breitenberg", Login = "LoginAgence1", MotDePasse = "123", PourcentageReduction = 0.09},
                new Agence() { Nom = "Bashirian, Goyette and Denesik", Login = "LoginAgence2", MotDePasse = "123", PourcentageReduction = 0.32},
                new Agence() { Nom = "Hyatt-Corwin", Login = "LoginAgence3", MotDePasse = "123", PourcentageReduction = 0.27}
                });

            context.Hotels.AddOrUpdate(new Hotel[] {
                new Hotel() { Nom = "Hotel 1", NbEtoile = 5},
                new Hotel() { Nom = "Hotel 2", NbEtoile = 4},
                new Hotel() { Nom = "Hotel 3", NbEtoile = 3}
                });

            context.Chambres.AddOrUpdate(new Chambre[] {
                // Hotel 1
                new Chambre() { Numero = 1, EstLibre = true, DateDisponibilite = "01/03/2021", PrixDeBase = 51, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png"},
                new Chambre() { Numero = 15, EstLibre = true, DateDisponibilite = "10/03/2021", PrixDeBase = 41, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png"},
                new Chambre() { Numero = 12, EstLibre = true, DateDisponibilite = "10/04/2021", PrixDeBase = 69, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png"},
                new Chambre() { Numero = 22, EstLibre = true, DateDisponibilite = "02/03/2021", PrixDeBase = 50, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png"},
                new Chambre() { Numero = 25, EstLibre = true, DateDisponibilite = "20/03/2021", PrixDeBase = 79, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png"},
                new Chambre() { Numero = 28, EstLibre = true, DateDisponibilite = "02/04/2021", PrixDeBase = 38, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png"},
                new Chambre() { Numero = 32, EstLibre = true, DateDisponibilite = "02/03/2021", PrixDeBase = 69, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png"},
                new Chambre() { Numero = 35, EstLibre = true, DateDisponibilite = "18/03/2021", PrixDeBase = 57, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png"},
                new Chambre() { Numero = 38, EstLibre = true, DateDisponibilite = "31/03/2021", PrixDeBase = 82, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png"},
                // Hotel 2
                new Chambre() { Numero = 1, EstLibre = true, DateDisponibilite = "01/03/2021", PrixDeBase = 51, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png"},
                new Chambre() { Numero = 15, EstLibre = true, DateDisponibilite = "10/03/2021", PrixDeBase = 41, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png"},
                new Chambre() { Numero = 12, EstLibre = true, DateDisponibilite = "10/04/2021", PrixDeBase = 69, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png"},
                new Chambre() { Numero = 22, EstLibre = true, DateDisponibilite = "02/03/2021", PrixDeBase = 50, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png"},
                new Chambre() { Numero = 25, EstLibre = true, DateDisponibilite = "20/03/2021", PrixDeBase = 79, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png"},
                new Chambre() { Numero = 28, EstLibre = true, DateDisponibilite = "02/04/2021", PrixDeBase = 38, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png"},
                new Chambre() { Numero = 32, EstLibre = true, DateDisponibilite = "02/03/2021", PrixDeBase = 69, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png"},
                new Chambre() { Numero = 35, EstLibre = true, DateDisponibilite = "18/03/2021", PrixDeBase = 57, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png"},
                new Chambre() { Numero = 38, EstLibre = true, DateDisponibilite = "31/03/2021", PrixDeBase = 82, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png"},
                // Hotel 3
                new Chambre() { Numero = 1, EstLibre = true, DateDisponibilite = "01/03/2021", PrixDeBase = 51, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png"},
                new Chambre() { Numero = 38, EstLibre = true, DateDisponibilite = "31/03/2021", PrixDeBase = 82, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png"},
                new Chambre() { Numero = 15, EstLibre = true, DateDisponibilite = "10/03/2021", PrixDeBase = 41, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png"},
                new Chambre() { Numero = 12, EstLibre = true, DateDisponibilite = "10/04/2021", PrixDeBase = 69, UrlImage = CHEMIN_DOSSIER_ASSETS + "1_lit.png"},
                new Chambre() { Numero = 22, EstLibre = true, DateDisponibilite = "02/03/2021", PrixDeBase = 50, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png"},
                new Chambre() { Numero = 25, EstLibre = true, DateDisponibilite = "20/03/2021", PrixDeBase = 79, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png"},
                new Chambre() { Numero = 28, EstLibre = true, DateDisponibilite = "02/04/2021", PrixDeBase = 38, UrlImage = CHEMIN_DOSSIER_ASSETS + "2_lit.png"},
                new Chambre() { Numero = 32, EstLibre = true, DateDisponibilite = "02/03/2021", PrixDeBase = 69, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png"},
                new Chambre() { Numero = 35, EstLibre = true, DateDisponibilite = "18/03/2021", PrixDeBase = 57, UrlImage = CHEMIN_DOSSIER_ASSETS + "3_lit.png"},
            });

            context.Reservations.AddOrUpdate(new Reservation[] {
                new Reservation() { Reference = "#79744", DateDebut = "02/01/2021", DateFin = "04/01/2021", NbPersonne = 2, InformationCarteCredit = "4716533460348581" },
                new Reservation() { Reference = "#79744", DateDebut = "02/02/2021", DateFin = "04/02/2021", NbPersonne = 2, InformationCarteCredit = "4716533460348581" }
                });
        }
    }
}
