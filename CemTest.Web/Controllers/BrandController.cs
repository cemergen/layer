using AutoMapper;
using CemTest.Business;
using CemTest.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CemTest.Web.Controllers
{
    public class BrandController : Controller
    {

        BrandBusiness business = new BrandBusiness();
        public ActionResult Index()
        {
            List<BrandViewModel> returnData = new List<BrandViewModel>();
            foreach (var item in business.GetAll())
            {
                returnData.Add(new BrandViewModel
                {
                    BrandName = item.BrandName,
                    Id = item.Id
                    
                });
            }
            return View(returnData);
        }
    }
}