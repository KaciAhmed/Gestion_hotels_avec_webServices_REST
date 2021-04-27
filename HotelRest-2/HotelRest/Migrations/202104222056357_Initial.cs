namespace HotelRest.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Initial : DbMigration
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
                    AgenceId = c.Int(nullable: false),
                    Nom = c.String(),
                    Login = c.String(),
                    MotDePasse = c.String(),
                    PourcentageReduction = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.AgenceId)
                .ForeignKey("dbo.Adresses", t => t.AgenceId)
                .Index(t => t.AgenceId);

            CreateTable(
                "dbo.Hotels",
                c => new
                {
                    HotelId = c.Int(nullable: false),
                    Nom = c.String(),
                    NbEtoile = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.HotelId)
                .ForeignKey("dbo.Adresses", t => t.HotelId)
                .Index(t => t.HotelId);

            CreateTable(
                "dbo.Chambres",
                c => new
                {
                    ChambreId = c.Int(nullable: false, identity: true),
                    Numero = c.Int(nullable: false),
                    EstLibre = c.Boolean(nullable: false),
                    DateDisponibilite = c.String(),
                    PrixDeBase = c.Single(nullable: false),
                    UrlImage = c.String(),
                    Image = c.Binary(),
                    Hotel_HotelId = c.Int(),
                    TypeChambre_TypeChambreId = c.Int(),
                })
                .PrimaryKey(t => t.ChambreId)
                .ForeignKey("dbo.Hotels", t => t.Hotel_HotelId)
                .ForeignKey("dbo.TypeChambres", t => t.TypeChambre_TypeChambreId)
                .Index(t => t.Hotel_HotelId)
                .Index(t => t.TypeChambre_TypeChambreId);

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
                    Agence_AgenceId = c.Int(),
                    Chambre_ChambreId = c.Int(),
                    Client_ClientId = c.Int(),
                })
                .PrimaryKey(t => t.ReservationId)
                .ForeignKey("dbo.Agences", t => t.Agence_AgenceId)
                .ForeignKey("dbo.Chambres", t => t.Chambre_ChambreId)
                .ForeignKey("dbo.Clients", t => t.Client_ClientId)
                .Index(t => t.Agence_AgenceId)
                .Index(t => t.Chambre_ChambreId)
                .Index(t => t.Client_ClientId);

            CreateTable(
                "dbo.Clients",
                c => new
                {
                    ClientId = c.Int(nullable: false, identity: true),
                    Nom = c.String(),
                    Prenom = c.String(),
                })
                .PrimaryKey(t => t.ClientId);

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
            DropForeignKey("dbo.Chambres", "TypeChambre_TypeChambreId", "dbo.TypeChambres");
            DropForeignKey("dbo.Reservations", "Client_ClientId", "dbo.Clients");
            DropForeignKey("dbo.Reservations", "Chambre_ChambreId", "dbo.Chambres");
            DropForeignKey("dbo.Reservations", "Agence_AgenceId", "dbo.Agences");
            DropForeignKey("dbo.Chambres", "Hotel_HotelId", "dbo.Hotels");
            DropForeignKey("dbo.HotelAgences", "Agence_AgenceId", "dbo.Agences");
            DropForeignKey("dbo.HotelAgences", "Hotel_HotelId", "dbo.Hotels");
            DropForeignKey("dbo.Hotels", "HotelId", "dbo.Adresses");
            DropForeignKey("dbo.Agences", "AgenceId", "dbo.Adresses");
            DropIndex("dbo.HotelAgences", new[] { "Agence_AgenceId" });
            DropIndex("dbo.HotelAgences", new[] { "Hotel_HotelId" });
            DropIndex("dbo.Reservations", new[] { "Client_ClientId" });
            DropIndex("dbo.Reservations", new[] { "Chambre_ChambreId" });
            DropIndex("dbo.Reservations", new[] { "Agence_AgenceId" });
            DropIndex("dbo.Chambres", new[] { "TypeChambre_TypeChambreId" });
            DropIndex("dbo.Chambres", new[] { "Hotel_HotelId" });
            DropIndex("dbo.Hotels", new[] { "HotelId" });
            DropIndex("dbo.Agences", new[] { "AgenceId" });
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
