using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Bussiness.Interface;

namespace ToDo.Bussiness
{
  public  class EmployeeBusiness : ITodoBussiness
    {
        public string title(int id)
        {
            return "Hello" + id;
        }
    }
}
