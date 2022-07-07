using CustomLogin_LINQ.Models;
using System.Linq;
using System.Web.Mvc;

namespace CustomLogin_LINQ.Controllers
{
    public class LoginController : Controller
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(login obj)
        {
            
            var data = db.logins.Where(s => s.username == obj.username && s.password == obj.password).FirstOrDefault();
            if(data != null)
            {
                return Content("Valid Data");
            }
            else
            {
                return Content("Invalid Data");
            }
        }
    }
}