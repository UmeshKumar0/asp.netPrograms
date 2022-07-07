using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using ConsumeWebAPI_Project.Models;

namespace ConsumeWebAPI_Project.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            IEnumerable<CustomerViewModel> customer = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:44323/api/");
                var responseTask = client.GetAsync("customer");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<CustomerViewModel>>();
                    readJob.Wait();
                    customer = readJob.Result;
                }
                else
                {
                    customer = Enumerable.Empty<CustomerViewModel>();
                    ModelState.AddModelError(string.Empty, "Server Error Occured . Please Contact admin for help");
                }
            }
            return View(customer);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CustomerViewModel customer)
        {
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56099/api/customer");
                var postJob = client.PostAsJsonAsync<CustomerViewModel>("customer",customer);
                postJob.Wait();

                var postResult = postJob.Result;
                if (postResult.IsSuccessStatusCode)
                    return RedirectToAction("Index");

            }
            ModelState.AddModelError(string.Empty, "Server occured error , Contact Admin!!");
            return View(customer);
        }
    }
}