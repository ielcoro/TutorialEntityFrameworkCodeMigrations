using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMigrationsSample.Model
{
    public abstract class Address
    {
        public int Id { get; set; }
        public string AddressName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
