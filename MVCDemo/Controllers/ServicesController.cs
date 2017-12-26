using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Service()
        {
            return View();
        }
        public ActionResult LaptopServices()
        {
            return View();
        }
        public ActionResult TVServices()
        {
            return View();
        }
        public ActionResult MobileServices()
        {
            return View();
        }
        public ActionResult MirowaveServices()
        {
            return View();
        }
    }
}