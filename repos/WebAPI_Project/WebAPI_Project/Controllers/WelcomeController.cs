using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class WelcomeController : ApiController
    {
        public string Get()
        {
            string strWelcome = "Hello World from My Side";
            return strWelcome;
        }
    }
}