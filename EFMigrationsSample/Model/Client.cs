using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMigrationsSample.Model
{
    public class Client
    {
        public int Id { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; }
        public int BillingAddressId { get; set; }
        public virtual BillingAddress BillingAddress { get; set; }
        public int DeliveryAddressId { get; set; }
        public virtual DeliveryAddress DeliveryAddress { get; set; }
    }
}
