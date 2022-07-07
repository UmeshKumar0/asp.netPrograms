using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAppl_todo.Bussiness_Layer;
using WebAppl_todo.Models;

namespace WebAppl_todo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Task()
        {
            BussinessLayer obj = new BussinessLayer();

            List<List> people = obj.List();
            return View(people);
        }


        [HttpPost]
        public JsonResult DeleteAll()
        {
            BussinessLayer obj = new BussinessLayer();
              JsonResult ab = obj.DeleteAll();
            return Json(ab);
        }



        [HttpGet]

        public JsonResult Delete(int id)
    {
            BussinessLayer obj = new BussinessLayer();
            JsonResult ab = obj.Delete(id);
            return Json(ab);

        }




        [HttpPost]
        public JsonResult Update(int id, string title, int time_spend)
        {
            BussinessLayer obj = new BussinessLayer();
            JsonResult ab = obj.Update(id,title,time_spend);
            return Json(ab);
        }


        [HttpPost]
        public JsonResult Insert(string title, int time_spend)
        {
            BussinessLayer obj = new BussinessLayer();
            JsonResult ab = obj.Insert(title,time_spend);
            return Json(ab);
        }
        
    }
}
