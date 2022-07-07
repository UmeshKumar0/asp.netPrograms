using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestWebAPI.Models;

namespace TestWebAPI.Controllers
{
    public class ProductController : ApiController
    {
        Entities1 db = new Entities1();

        // Add Post Request
       
        public string Post(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return "Product Added Sucessfully";
        }
    }
}
