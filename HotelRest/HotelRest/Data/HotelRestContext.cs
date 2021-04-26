using System.Data.Entity;

namespace HotelRest.Data
{
    public class HotelRestContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public HotelRestContext() : base("name=HotelRestContext")
        {
        }

        public System.Data.Entity.DbSet<HotelRest.Models.TypeChambre> TypeChambres { get; set; }

        public System.Data.Entity.DbSet<HotelRest.Models.Chambre> Chambres { get; set; }

        public System.Data.Entity.DbSet<HotelRest.Models.Adresse> Adresses { get; set; }

        public System.Data.Entity.DbSet<HotelRest.Models.Agence> Agences { get; set; }

        public System.Data.Entity.DbSet<HotelRest.Models.Hotel> Hotels { get; set; }

        public System.Data.Entity.DbSet<HotelRest.Models.Client> Clients { get; set; }

        public System.Data.Entity.DbSet<HotelRest.Models.Reservation> Reservations { get; set; }
    }
}
