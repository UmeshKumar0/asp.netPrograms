 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginWeb_Linq_SQL.Models;

namespace LoginWeb_Linq_SQL.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDetailsDataContext emp = new EmployeeDetailsDataContext();

        // GET: Home
        
        public ActionResult Index()
        {
            var data = emp.Employees.ToList();
            return View(data);
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            var dataByid = emp.Employees.Single(x => x.empid == id);
            return View(dataByid);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(Employee collection)
        {
            try
            {
                emp.Employees.InsertOnSubmit(collection);   
                emp.SubmitChanges();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            var dataByid = emp.Employees.Single(x => x.empid == id);
            return View(dataByid);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee collection)
        {
            try
            {
                Employee empobj = emp.Employees.Single(x => x.empid == id);
                empobj.empname = collection.empname;
                empobj.empfathername = collection.empfathername;
                empobj.empsalary = collection.empsalary;
                emp.SubmitChanges();
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            var dataByid = emp.Employees.Single(x => x.empid == id);
            return View(dataByid);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Employee collection)
        {
            try
            {
                var data = emp.Employees.Single(x => x.empid == id);
                emp.Employees.DeleteOnSubmit(data);
                emp.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
