using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ToDoList2.Controllers
{
    public class AjaxAPIController : ApiController
    {
        // GET api/<controller>
        [Route("api/AjaxAPI/InsertData")]
        [HttpPost]
        public ListData InsertData(ListData _customer)
        {
            using (TodoListEntities entities = new TodoListEntities())
            {
                _customer = entities.DataCRUD("INSERT", null, _customer.Title, _customer.TimeSpend , _customer.CreatedAt).FirstOrDefault();
            }

            return _customer;
        }

        [Route("api/AjaxAPI/UpdateData")]
        [HttpPost]
        public bool UpdateData(ListData _customer)
        {
            using (TodoListEntities entities = new TodoListEntities())
            {
                entities.DataCRUD("UPDATE", _customer.ID, _customer.Title, _customer.TimeSpend, _customer.CreatedAt);
            }

            return true;
        }

        [Route("api/AjaxAPI/DeleteData")]
        [HttpPost]
        public void DeleteData(ListData _customer)
        {
            using (TodoListEntities entities = new TodoListEntities())
            {
                entities.DataCRUD("DELETE", _customer.ID, null, null , null);
            }
        }
    }
}