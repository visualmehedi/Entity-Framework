using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF6.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public decimal OrderValue { get; set; }
        public virtual List<Order> Orders { get; set; }

    }
}
