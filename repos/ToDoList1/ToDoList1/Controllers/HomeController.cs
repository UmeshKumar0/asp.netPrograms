using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ToDoList1.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
          
           
                TodoListEntities10 to = new TodoListEntities10();
            List<ListData> list = to.DataCRUD("SELECT", null, null, null,null).ToList();
            if (list.Count == 0)
            {
                list.Add(new ListData());
            }

            return View(list);


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