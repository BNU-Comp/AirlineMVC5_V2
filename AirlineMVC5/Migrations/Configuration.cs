namespace AirlineMVC5.Migrations
{
    using AirlineMVC5.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AirlineMVC5.Models.ApplicationDbContext";
        }

        protected override void Seed(ApplicationDbContext context)
        {
            SeedAddresses(context);
            SeedAirports(context);
            SeedFlights(context);
        }

        private void SeedFlights(ApplicationDbContext context)
        {
            
        }

        private void SeedAirports(ApplicationDbContext context)
        {
            
        }

        /// <summary>
        /// Make each Post Code Unique please
        /// </summary>
        private void SeedAddresses(ApplicationDbContext context)
        {
            var Addresses = new List<Address>
            {
                new Address
                {
                    AddressID = 1,
                    HouseNumber = "23",
                    Street = "High Street",
                    Town = "St Albans",
                    County = Counties.Herefordshire,
                    PostCode = "AL1 4FT"
                }
            };

            Addresses.ForEach(
                a => context.Addresses.AddOrUpdate(
                    p => p.PostCode, a));

            context.SaveChanges();
        }
    }
}
