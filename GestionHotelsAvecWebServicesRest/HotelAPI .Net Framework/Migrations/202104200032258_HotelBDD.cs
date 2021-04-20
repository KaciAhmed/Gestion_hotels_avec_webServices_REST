namespace HotelAPI.Net_Framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HotelBDD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        AdresseId = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Rue = c.String(),
                        Pays = c.String(),
                        PositionGPS = c.String(),
                        LieuDit = c.String(),
                    })
                .PrimaryKey(t => t.AdresseId);
            
            CreateTable(
                "dbo.Agences",
                c => new
                    {
                        AgenceId = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Login = c.String(),
                        MotDePasse = c.String(),
                        PourcentageReduction = c.Double(nullable: false),
                        Adresse_AdresseId = c.Int(),
                    })
                .PrimaryKey(t => t.AgenceId)
                .ForeignKey("dbo.Adresses", t => t.Adresse_AdresseId)
                .Index(t => t.Adresse_AdresseId);
            
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        HotelId = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        NbEtoile = c.Int(nullable: false),
                        Adresse_AdresseId = c.Int(),
                    })
                .PrimaryKey(t => t.HotelId)
                .ForeignKey("dbo.Adresses", t => t.Adresse_AdresseId)
                .Index(t => t.Adresse_AdresseId);
            
            CreateTable(
                "dbo.Chambres",
                c => new
                    {
                        ChambreId = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        EstLibre = c.Boolean(nullable: false),
                        DateDisponibilite = c.String(),
                        PrixDeBase = c.Single(nullable: false),
                        TypeChambreId = c.Int(nullable: false),
                        HotelId = c.Int(nullable: false),
                        UrlImage = c.String(),
                        Image = c.Binary(),
                    })
                .PrimaryKey(t => t.ChambreId)
                .ForeignKey("dbo.Hotels", t => t.HotelId, cascadeDelete: true)
                .ForeignKey("dbo.TypeChambres", t => t.TypeChambreId, cascadeDelete: true)
                .Index(t => t.TypeChambreId)
                .Index(t => t.HotelId);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationId = c.Int(nullable: false, identity: true),
                        Reference = c.String(),
                        DateDebut = c.String(),
                        DateFin = c.String(),
                        NbPersonne = c.Int(nullable: false),
                        InformationCarteCredit = c.String(),
                        ClientId = c.Int(nullable: false),
                        AgenceId = c.Int(nullable: false),
                        ChambreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReservationId)
                .ForeignKey("dbo.Agences", t => t.AgenceId, cascadeDelete: true)
                .ForeignKey("dbo.Chambres", t => t.ChambreId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.AgenceId)
                .Index(t => t.ChambreId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Agence_AgenceId = c.Int(),
                    })
                .PrimaryKey(t => t.ClientId)
                .ForeignKey("dbo.Agences", t => t.Agence_AgenceId)
                .Index(t => t.Agence_AgenceId);
            
            CreateTable(
                "dbo.TypeChambres",
                c => new
                    {
                        TypeChambreId = c.Int(nullable: false, identity: true),
                        NbLits = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TypeChambreId);
            
            CreateTable(
                "dbo.HotelAgences",
                c => new
                    {
                        Hotel_HotelId = c.Int(nullable: false),
                        Agence_AgenceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Hotel_HotelId, t.Agence_AgenceId })
                .ForeignKey("dbo.Hotels", t => t.Hotel_HotelId, cascadeDelete: true)
                .ForeignKey("dbo.Agences", t => t.Agence_AgenceId, cascadeDelete: true)
                .Index(t => t.Hotel_HotelId)
                .Index(t => t.Agence_AgenceId);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Chambres", "TypeChambreId", "dbo.TypeChambres");
            DropForeignKey("dbo.Reservations", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Clients", "Agence_AgenceId", "dbo.Agences");
            DropForeignKey("dbo.Reservations", "ChambreId", "dbo.Chambres");
            DropForeignKey("dbo.Reservations", "AgenceId", "dbo.Agences");
            DropForeignKey("dbo.Chambres", "HotelId", "dbo.Hotels");
            DropForeignKey("dbo.HotelAgences", "Agence_AgenceId", "dbo.Agences");
            DropForeignKey("dbo.HotelAgences", "Hotel_HotelId", "dbo.Hotels");
            DropForeignKey("dbo.Hotels", "Adresse_AdresseId", "dbo.Adresses");
            DropForeignKey("dbo.Agences", "Adresse_AdresseId", "dbo.Adresses");
            DropIndex("dbo.HotelAgences", new[] { "Agence_AgenceId" });
            DropIndex("dbo.HotelAgences", new[] { "Hotel_HotelId" });
            DropIndex("dbo.Clients", new[] { "Agence_AgenceId" });
            DropIndex("dbo.Reservations", new[] { "ChambreId" });
            DropIndex("dbo.Reservations", new[] { "AgenceId" });
            DropIndex("dbo.Reservations", new[] { "ClientId" });
            DropIndex("dbo.Chambres", new[] { "HotelId" });
            DropIndex("dbo.Chambres", new[] { "TypeChambreId" });
            DropIndex("dbo.Hotels", new[] { "Adresse_AdresseId" });
            DropIndex("dbo.Agences", new[] { "Adresse_AdresseId" });
            DropTable("dbo.HotelAgences");
            DropTable("dbo.TypeChambres");
            DropTable("dbo.Clients");
            DropTable("dbo.Reservations");
            DropTable("dbo.Chambres");
            DropTable("dbo.Hotels");
            DropTable("dbo.Agences");
            DropTable("dbo.Adresses");
        }
    }
}
