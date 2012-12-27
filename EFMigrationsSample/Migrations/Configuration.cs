namespace EFMigrationsSample.Migrations
{
    using EFMigrationsSample.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFMigrationsSample.TinyERPSampleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFMigrationsSample.TinyERPSampleContext context)
        {
            context.Clients.AddOrUpdate(
                new Client()
                {
                    Name = "Client 1",
                    City = "Bilbao",
                    Address = "Carolina 3, 4-D",
                    State = "Vizcaya"
                },
                new Client()
                {
                    Name = "Client 2",
                    City = "Eibar",
                    Address = "Pantxineta 4, 5-A",
                    State = "Eibar"
                });
        }
    }
}
