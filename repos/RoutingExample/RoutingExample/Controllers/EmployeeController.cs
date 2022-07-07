using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingExample.Controllers
{
    public class EmployeeController : Controller
    {
        [OutputCache(Duration =10)]
        // GET: Employee
        public ActionResult Search(string name)
        {
            var input = Server.HtmlEncode(name);
            return Content( " Welcome "+input +" " + DateTime.Now.ToString("T"));
            
        }
    }
}