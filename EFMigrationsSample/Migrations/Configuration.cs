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
           
        }
    }
}
