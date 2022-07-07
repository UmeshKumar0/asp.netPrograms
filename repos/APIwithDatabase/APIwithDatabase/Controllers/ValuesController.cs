using APIwithDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIwithDatabase.Controllers
{
    public class ValuesController : ApiController
    {
        database_access_layer.db dblayer = new database_access_layer.db();
        [HttpPost]
        public IHttpActionResult AddCustomer([FromBody] customers cs)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                dblayer.Add_Customer(cs);
                return Ok("Success");
            }
            catch (Exception)
            {
                return Ok("Something went wrong, try later");

            }
        }
        }
    }
