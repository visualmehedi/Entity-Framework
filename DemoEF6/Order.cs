using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoEF6.Model;

namespace DemoEF6
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public decimal SubTotal { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
