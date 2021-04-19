using GestionHotelsAvecWebServicesRest.Models;
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

        public DbSet<TypeChambre> TypeChambres { get; set; }

        public DbSet<Adresse> Adresses { get; set; }

        public DbSet<Chambre> Chambres { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Agence> Agences { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<AgencesHotels> AgencesHotels { get; set; }
    }
}
