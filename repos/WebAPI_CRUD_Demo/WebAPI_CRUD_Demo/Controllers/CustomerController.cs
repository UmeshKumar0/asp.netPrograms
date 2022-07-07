using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_CRUD_Demo.Models;

namespace WebAPI_CRUD_Demo.Controllers
{
    public class CustomerController : ApiController
    {
        public IHttpActionResult GetAllCustomer()
        {
            IList<CustomerViewModel> customers = null;
            using (var x = new WebAPIDemo_DBEntities())
            {
                customers = x.Customers.Select(c => new CustomerViewModel()
                {
                    Id = c.id,
                    Name = c.name,
                    Email = c.email,
                    Address = c.address,
                    Phone = c.phone
                }).ToList<CustomerViewModel>() ;

            }
            if (customers.Count == 0)
                return NotFound();
            return Ok(customers);
        }
        public IHttpActionResult PostNewCustomer(CustomerViewModel customer)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Data , Please Recheck !!");

            using(var x = new WebAPIDemo_DBEntities())
            {
                x.Customers.Add(new Customer()
                {
                    id = customer.Id,
                    name = customer.Name,
                    email = customer.Email,
                    address = customer.Address,
                    phone = customer.Phone
                });

                x.SaveChanges();
            }
            return Ok();
        }

        public IHttpActionResult PutCustomer(CustomerViewModel customer)
        {
            if (!ModelState.IsValid)
                return BadRequest("This is Invalid Model , Please Recheck !!");

            using (var x = new WebAPIDemo_DBEntities())
            {
                var checkExistingCustomer = x.Customers.Where(c => c.id == customer.Id).FirstOrDefault<Customer>();
                if (checkExistingCustomer != null)
                {
                    checkExistingCustomer.name = customer.Name;
                    checkExistingCustomer.address = customer.Address;
                    checkExistingCustomer.phone = customer.Phone;

                    x.SaveChanges();
                }
                else
                    return NotFound();
            }
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            if(id <= 0)
            
                return BadRequest("Please Enter a Valid Customer ID");

                using (var x = new WebAPIDemo_DBEntities())
                {
                    var customer = x.Customers.Where(c => c.id == id).FirstOrDefault();
                    x.Entry(customer).State = System.Data.Entity.EntityState.Deleted;
                    x.SaveChanges();
                }
                return Ok();   
        }
    }
}
