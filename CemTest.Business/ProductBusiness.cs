using CemTest.Data;
using CemTest.Data.Repository;
using CemTest.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CemTest.Business
{
    public class ProductBusiness : GenericRepository<DefaultContext, Product>
    {
    }
}
