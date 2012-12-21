using EFMigrationsSample.Mapping;
using EFMigrationsSample.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMigrationsSample
{
    public class TinyERPSampleContext
        : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClientsMapping());
            modelBuilder.Configurations.Add(new OrdersMapping());
        }
    }
}
