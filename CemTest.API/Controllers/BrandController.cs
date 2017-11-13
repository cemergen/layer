using CemTest.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CemTest.API.Controllers
{
    public class BrandController : ApiController
    {
        Business.BrandBusiness brandBusiness = new Business.BrandBusiness();

        public IHttpActionResult GetJson()
        {
            return Json(brandBusiness.GetAll());
        }

        public IEnumerable<Brand> GetXML()
        {
            return (brandBusiness.GetAll());
        }
    }
}
