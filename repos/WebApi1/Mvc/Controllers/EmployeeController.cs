using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Mvc.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            IEnumerable<mvcEmployeeModel> empList;
            HttpResponseMessage response = GlobalVariabes.WebApiClient.GetAsync("Employees").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<mvcEmployeeModel>>().Result;
            return View(empList);
        }
        public ActionResult AddOrEdit( int id = 0)
        {
            if (id ==0)
            return View(new mvcEmployeeModel());
            else
            {
                HttpResponseMessage response = GlobalVariabes.WebApiClient.GetAsync("Employees/"+id.ToString()).Result;
                return View(response.Content.ReadAsAsync<mvcEmployeeModel>().Result);
            }
        }
        [HttpPost]
        public ActionResult AddOrEdit(mvcEmployeeModel emp)
        {
            if (emp.EmployeeID == 0)
            {
                HttpResponseMessage response = GlobalVariabes.WebApiClient.PostAsJsonAsync("Employees", emp).Result;
                TempData["SuccessMessage"] = "Saved Sucessfully";
            }
            else
            {
                HttpResponseMessage response = GlobalVariabes.WebApiClient.PutAsJsonAsync("Employees/"+emp.EmployeeID,emp).Result;
                TempData["SuccessMessage"] = "Updated Sucessfully";
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete( int id)
        {
            HttpResponseMessage response = GlobalVariabes.WebApiClient.DeleteAsync("Employees/"+id.ToString()).Result;
            TempData["SuccessMessage"] = "Deleted Sucessfully";
            return RedirectToAction("Index");
        }
    }
}