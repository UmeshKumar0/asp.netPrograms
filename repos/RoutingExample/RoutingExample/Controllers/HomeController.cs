using RoutingExample.ActionFilters;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingExample.Controllers
{[CustomAction]
    public class HomeController : Controller
    {
        [OutputCache(Duration = 10)]
        public ActionResult Index()
        {
            return View();
        }
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
       
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}