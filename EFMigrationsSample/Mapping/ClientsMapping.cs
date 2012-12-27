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
    public class ClientsMapping 
        : EntityTypeConfiguration<Client>
    {
        public ClientsMapping()
        {
            this.ToTable("Clients");
            
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }

    }
}
