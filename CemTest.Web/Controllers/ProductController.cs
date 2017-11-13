using CemTest.Business;
using CemTest.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CemTest.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductBusiness business = new ProductBusiness();
        public ActionResult Index()
        {

            List<ProductViewModel> returnData = new List<ProductViewModel>();
            foreach (var item in business.GetAll())
            {
                returnData.Add(new ProductViewModel
                {
                    ProductName = item.ProductName,
                    Id = item.Id,
                    BrandName = item.Brand.BrandName
                });
            }
            return View(returnData);
        }
    }
}