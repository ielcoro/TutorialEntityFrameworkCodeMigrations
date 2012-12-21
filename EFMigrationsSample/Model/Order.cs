using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMigrationsSample.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set;}
    }
}
