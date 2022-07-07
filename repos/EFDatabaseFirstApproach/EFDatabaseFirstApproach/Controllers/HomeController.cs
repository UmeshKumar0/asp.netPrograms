using EFDatabaseFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFDatabaseFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        EFDatabaseApproachEntities db = new EFDatabaseApproachEntities();
        public ActionResult Index()
        {
            var data = db.EmployeeDBFirsts.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeDBFirst emp)
        {

            if(ModelState.IsValid == true)
            {
                db.EmployeeDBFirsts.Add(emp);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["CreateMessage"] = "<script>alert('New Data Added Successfully')</script>";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["CreateMessage"] = "<script>alert('No Added')</script>";
                }
            }
           
            return View();
        }
        public ActionResult Edit(int id)
        {
            var data = db.EmployeeDBFirsts.Where(model => model.Id == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeDBFirst emp)
        {
            if(ModelState.IsValid == true)
            {
                db.Entry(emp).State = EntityState.Modified;
                int a = db.SaveChanges();
                if(a > 0)
                {
                    TempData["EditMessage"] = "<script>alert('Edited Successfully')</script>";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["EditMessage"] = "<script>alert('Not Edited')</script>";
                }
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            var data = db.EmployeeDBFirsts.Where(model => model.Id == id).FirstOrDefault();
            if(data != null)
            {
                db.Entry(data).State = EntityState.Deleted;
                int a = db.SaveChanges();

                if(a > 0)
                {
                    TempData["DeleteMessage"] = "<script>alert('Deleted Successfully')</script>";
                }
                else
                {
                    TempData["DeleteMessage"] = "<script>alert('Not Deleted')</script>";
                }
            }
            return RedirectToAction("Index"); 
        }
        public ActionResult Details(int id)
        {
            var data = db.EmployeeDBFirsts.Where(model => model.Id == id).FirstOrDefault();
            return View(data);
        }
    }
}