using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Welcome(string Name)
        {
            return "Hello "+ Name ;
        }
    }
}
