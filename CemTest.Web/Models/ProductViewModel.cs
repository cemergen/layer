using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CemTest.Web.Models
{
    public class ProductViewModel
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [DisplayName("Brand Name")]
        public string BrandName { get; set; }
    }
}