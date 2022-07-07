using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserLoginExample.Controllers
{
    public class CheckAuthController : Controller
    {
        // GET: CheckAuth
        public ContentResult Index()
        {
            return Content("Hello, You are Guest.");
        }
        // GET: CheckAuth/AuthorisedOnly  
        [Authorize]
        public ContentResult AuthorisedOnly()
        {
            return Content("You are registered user.");
        }
    }
}