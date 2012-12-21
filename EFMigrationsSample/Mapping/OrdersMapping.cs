using EFMigrationsSample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMigrationsSample.Mapping
{
    public class OrdersMapping
        : EntityTypeConfiguration<Order>
    {
        public OrdersMapping()
        {
            this.ToTable("Orders");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.SubTotal).IsRequired().HasPrecision(10, 2);
            this.Property(x => x.SubTotal).IsRequired().HasPrecision(10, 2);
        }
    }
}
