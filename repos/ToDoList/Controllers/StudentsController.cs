using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
      
    }
}
