using EFCodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCodeFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        StudentContext db = new StudentContext();
        public ActionResult Index()
        {
            var data = db.Students.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {

            if (ModelState.IsValid == true)
            {
                db.Students.Add(s);
                int a = db.SaveChanges();

                if (a > 0)
                { //Checking if a is getting the ID or not
                    TempData["InsertData"] = "<script>alert('Data Inserted Successfully')</script>";
                    return RedirectToAction("Index");

                }
                else
                {
                    ViewBag.InsertData = "<script>alert('Data Not Inserted Successfully !!!')</script>";
                }


            }

            return View();
        }
        public ActionResult Edit(int id)
        {
            
             var row = db.Students.Where(model => model.Id == id).FirstOrDefault();
                return View(row);
          
            
        }

        [HttpPost]
        public ActionResult Edit(Student s)
        {


            if(ModelState.IsValid == true)
            {
                db.Entry(s).State = EntityState.Modified;
                int a = db.SaveChanges();

                if (a > 0)
                {
                    TempData["UpdateMessage"] = "<script>alert('Update Successfully')</script>";
                    return RedirectToAction("Index");
                    
                }
                else
                {
                    ViewBag.UpdateMessage = "<script>alert('Update Unsuccessfully')</script>";
                }
            }
           
            return View();
        }
        public ActionResult Delete(int id)
        {
            
            if (id > 0)
            {
                var row = db.Students.Where(model => model.Id == id).FirstOrDefault();
                if(row != null)
                {
                    db.Entry(row).State = EntityState.Deleted;
                    int a = db.SaveChanges();
                    if (a > 0)
                    {
                        TempData["DeleteMessage"] = "<script>alert('Deleted Successfully')</script>";
                        
                    }
                    else
                    {
                        ViewBag.DeleteMessage = "<script>alert('Deleted Unsuccessfully')</script>";
                    }
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var row = db.Students.Where(model => model.Id == id).FirstOrDefault();
           
            return View(row);
        }
    }
}