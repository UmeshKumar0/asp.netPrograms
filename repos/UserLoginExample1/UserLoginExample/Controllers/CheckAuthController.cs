using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UserLoginExample.Controllers
{
    public class CheckAuthController : Controller
    {
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
