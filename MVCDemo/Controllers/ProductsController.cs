using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult Laptop()
        {
            return View();
        }
        public ActionResult TV()
        {
            return View();
        }
        public ActionResult Mobile()
        {
            return View();
        }
        public ActionResult Microwave()
        {
            return View();
        }
    }
}