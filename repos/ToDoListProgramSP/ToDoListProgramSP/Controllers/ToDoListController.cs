using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoListProgramSP.BusinessLayer;
using ToDoListProgramSP.Models;

namespace ToDoListProgramSP.Controllers
{
    public class ToDoListController : Controller
    {
        [HttpGet]
        public ActionResult InsertCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsertCustomer(ToDoListController ToDo)
        {

            
            if (ModelState.IsValid) //checking model is valid or not    
            {
                ToDo objDB = new ToDo();
                string result = objDB.InsertData(ToDo);
                //ViewData["result"] = result;    
                TempData["result1"] = result;
                ModelState.Clear(); //clearing model    
                                    //return View();    
                return RedirectToAction("ShowAllData");
            }

            else
            {
                ModelState.AddModelError("", "Error in saving data");
                return View();
            }
        }

        [HttpGet]
        public ActionResult ShowAllData()
        {
           ToDo ToDo = new ToDo();
            ToDo objDB = new ToDo(); //calling class DBdata    
            ToDoList.SelectallData = objDB.Selectalldata();
            return View(ToDo);
        }
        [HttpGet]
        public ActionResult Details(string ID)
        {
            //Customer objCustomer = new Customer();    
            //DataAccessLayer objDB = new DataAccessLayer(); //calling class DBdata    
            //objCustomer.ShowallCustomer = objDB.Selectalldata();    
            //return View(objCustomer);    
            ToDo objCustomer = new ToDo();
            ToDo objDB = new ToDo(); //calling class DBdata    
            return View(objDB.SelectDatabyID(ID));
        }
        [HttpGet]
        public ActionResult Edit(string ID)
        {
            ToDo objCustomer = new ToDo();
            ToDo objDB = new ToDo(); //calling class DBdata    
            return View(objDB.SelectDatabyID(ID));
        }

        [HttpPost]
        public ActionResult Edit(ToDo obj)
        {
            
            if (ModelState.IsValid) //checking model is valid or not    
            {
                ToDo objDB = new ToDo(); //calling class DBdata    
                string result = objDB.UpdateData(obj);
                //ViewData["result"] = result;    
                TempData["result2"] = result;
                ModelState.Clear(); //clearing model    
                //return View();    
                return RedirectToAction("ShowAllData");
            }
            else
            {
                ModelState.AddModelError("", "Error in saving data");
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(String ID)
        {
            ToDo objDB = new ToDo();
            int result = objDB.DeleteData(ID);
            TempData["result3"] = result;
            ModelState.Clear(); //clearing model    
                                //return View();    
            return RedirectToAction("ShowAllData");
        }
    }
}