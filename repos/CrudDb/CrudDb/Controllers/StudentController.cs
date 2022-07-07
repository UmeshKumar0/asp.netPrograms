using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudDb.Context;

namespace CrudDb.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        EmployeeEntities dbObj = new EmployeeEntities();
        public ActionResult Student(db_Student obj)
        { 
                return View(obj);
        }

        [HttpPost]
        public ActionResult AddStudent(db_Student model)
        {
            db_Student obj = new db_Student();
            if (ModelState.IsValid)
            {
                obj.ID = model.ID;
                obj.Name = model.Name;
                obj.Fname = model.Fname;
                obj.Email = model.Email;
                obj.Mobile = model.Mobile;
                obj.Description = model.Description;
                if(model.ID == 0)
                {
                    dbObj.db_Student.Add(obj);
                    dbObj.SaveChanges();
                }

                else
                {
                    dbObj.Entry(obj).State = EntityState.Modified;
                    dbObj.SaveChanges();
                }
                ModelState.Clear();
            }
           
            return View("Student");
        }




        public ActionResult StudentList()
        {
            var res = dbObj.db_Student.ToList();
            return View(res);
        }

        public ActionResult Delete(int id)
        {
            var res = dbObj.db_Student.Where(x => x.ID == id).First();
            dbObj.db_Student.Remove(res);
            dbObj.SaveChanges();
            var list = dbObj.db_Student.ToList();
            return View("StudentList",list);
        }
    }
}