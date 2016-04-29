using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DemoEF6.Model
{
    class DemoEF6Context : DbContext
    {
        public DemoEF6Context()
            //: base("name=DemoEF6Context")
        { }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
