using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ToDoList1.Controllers
{
    public class ValuesController1 : ApiController
    {
        [Route("api/AjaxAPI/InsertCustomer")]
        [HttpPost]
        public ListData InsertCustomer(ListData _customer)
        {
            using (TodoListEntities10 to = new TodoListEntities10())
            {
                _customer = to.DataCRUD("INSERT", null, _customer.Title, _customer.TimeSpend , _customer.CreatedAt).FirstOrDefault();
            }

            return _customer;
        }

        [Route("api/AjaxAPI/UpdateCustomer")]
        [HttpPost]
        public bool UpdateCustomer(ListData _customer)
        {
            using (TodoListEntities10 entities = new TodoListEntities10())
            {
                entities.DataCRUD("UPDATE", _customer.ID, _customer.Title, _customer.TimeSpend, _customer.CreatedAt);
            }

            return true;
        }

        [Route("api/AjaxAPI/DeleteCustomer")]
        [HttpPost]
        public void DeleteCustomer(ListData _customer)
        {
            using (TodoListEntities10 entities = new TodoListEntities10())
            {
                entities.DataCRUD("DELETE", _customer.ID, null, null ,null);
            }
        }
    }
}