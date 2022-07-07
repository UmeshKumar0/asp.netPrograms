using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ToDoList.Controllers
{
    public class World : System.Web.Mvc.Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return (IActionResult)View();
        }
        
    
    }
}
