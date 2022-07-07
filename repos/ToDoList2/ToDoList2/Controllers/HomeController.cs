using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToDoList2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TodoListEntities entities = new TodoListEntities();
            List<ListData> customers = entities.DataCRUD("SELECT", null, null, null,null).ToList();
            if (customers.Count == 0)
            {
                customers.Add(new ListData());
            }

            return View(customers);
        }
    }

     
    }
