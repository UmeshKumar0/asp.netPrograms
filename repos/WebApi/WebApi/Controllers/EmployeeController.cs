using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    [RoutePrefix("api/employee")]
    public class EmployeeController : ApiController
    {
        [Route("Add")]
        [HttpPost]
        public IHttpActionResult AddEmployee(Employee obj_emp)
        {
            string json;
            masterEntities db = new masterEntities();
            db.Employees.Add(obj_emp);
            db.SaveChanges();
            json = JsonConvert.SerializeObject(obj_emp);
            var response = this.Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri + obj_emp.Id.ToString());
            response.Content = new StringContent(json, Encoding.UTF8, "json");


            return ResponseMessage(response);
        }

        [HttpGet]
        public string Get()
        {
            return "Hello World";
        }
    }
}
