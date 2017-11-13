using CemTest.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CemTest.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext():base("DefaultContext")
        {

        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
