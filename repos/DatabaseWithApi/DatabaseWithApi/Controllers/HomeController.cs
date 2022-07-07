using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseWithApi.Models;

namespace DatabaseWithApi.Controllers
{
    public class HomeController : Controller
    {
        DemoEntities reterive = new DemoEntities();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View(reterive);
        }
    }
}
