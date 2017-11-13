using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CemTest.Entity
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public Brand Brand { get; set; }
    }
}
