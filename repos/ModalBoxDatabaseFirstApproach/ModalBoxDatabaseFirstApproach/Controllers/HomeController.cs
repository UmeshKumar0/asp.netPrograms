
using ModalBoxDatabaseFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModalBoxDatabaseFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetEmployees()
        {
            using(MyDatabaseEntities dc = new MyDatabaseEntities())
            {
                var employees = dc.Tables.OrderBy(a => a.FirstName).ToList();
                return Json(new { data = employees }, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult Save(int id)
        {
            using(MyDatabaseEntities dc = new MyDatabaseEntities())
            {
                var data = dc.Tables.Where(a => a.EmployeeId == id).FirstOrDefault();
                return View(data);
            }
        }
        [HttpPost]
        public ActionResult Save(Table obj)
        {
            bool status = false;
            if(ModelState.IsValid)
            {
                using(MyDatabaseEntities dc = new MyDatabaseEntities())
                {
                    if(obj.EmployeeId > 0)
                    {

                        var data = dc.Tables.Where(a => a.EmployeeId == obj.EmployeeId).FirstOrDefault();
                        if (data != null)
                        {
                            data.FirstName = obj.FirstName;
                            data.LastName = obj.LastName;
                            data.EmailtId = obj.EmailtId;
                            data.City = obj.City;
                            data.Country = obj.Country;
                        }

                    }
                    else
                    {
                        dc.Tables.Add(obj);
                    }
                    dc.SaveChanges();
                    status = true;
                }
            }
            return new JsonResult { Data = new { status = status } };
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            using(MyDatabaseEntities dc = new MyDatabaseEntities())
            {
                var data = dc.Tables.Where(a => a.EmployeeId == id).FirstOrDefault();
                if(data != null)
                {
                    return View(data);
                }
                else
                {
                    return HttpNotFound();
                }
            }
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteEmployee(int id)
        {
            bool status = false;
            using(MyDatabaseEntities dc = new MyDatabaseEntities())
            {
                var data = dc.Tables.Where(a => a.EmployeeId == id).FirstOrDefault();
                if(data != null)
                {
                    dc.Tables.Remove(data);
                    dc.SaveChanges();
                    status = true;
                }
            }
            return new JsonResult{Data = new {status = status} };
        }
    }
}