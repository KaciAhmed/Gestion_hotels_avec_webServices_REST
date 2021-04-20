using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HotelAPI.Net_Framework.Data
{
    public class HotelAPINet_FrameworkContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public HotelAPINet_FrameworkContext() : base("name=HotelAPINet_FrameworkContext")
        {
        }

        public System.Data.Entity.DbSet<GestionHotelsAvecWebServicesRest.Models.TypeChambre> TypeChambres { get; set; }

        public System.Data.Entity.DbSet<GestionHotelsAvecWebServicesRest.Models.Reservation> Reservations { get; set; }

        public System.Data.Entity.DbSet<GestionHotelsAvecWebServicesRest.Models.Agence> Agences { get; set; }

        public System.Data.Entity.DbSet<GestionHotelsAvecWebServicesRest.Models.Chambre> Chambres { get; set; }

        public System.Data.Entity.DbSet<GestionHotelsAvecWebServicesRest.Models.Client> Clients { get; set; }

        public System.Data.Entity.DbSet<GestionHotelsAvecWebServicesRest.Models.Hotel> Hotels { get; set; }

        public System.Data.Entity.DbSet<GestionHotelsAvecWebServicesRest.Models.Adresse> Adresses { get; set; }
    }
}
