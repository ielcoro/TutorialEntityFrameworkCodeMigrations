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
    public class AddressesMapping : EntityTypeConfiguration<Address>
    {
        public AddressesMapping()
        {
            this.Map(x => x.ToTable("AddressBook"));
            this.Map<DeliveryAddress>(x => x.Requires("AddressType").HasValue("Delivery"));
            this.Map<BillingAddress>(x => x.Requires("AddressType").HasValue("Billing"));

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.AddressName).IsRequired();
            this.Property(x => x.City).IsRequired();
            this.Property(x => x.State).IsRequired();
        }
    }
}
