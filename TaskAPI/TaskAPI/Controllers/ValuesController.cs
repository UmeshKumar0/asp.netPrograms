using Microsoft.AspNetCore.Mvc;
using TaskAPI.Model;
using TaskAPI.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        
        
        
        
        // GET: api/<User List>
        [HttpGet("~/UserList")]
        public IEnumerable<Login> Get()
        {
            IServices services = new BusinessLogic();
            List<Login> list = services.UserList1();
            return list;
        }




        // POST api/<Verify>
        [HttpPost("~/Verify")]
        public IActionResult Verify(Login acc)
        {
            IServices services = new BusinessLogic();
            bool a = services.ConnectToData(acc);
            if(a)
            {
                return StatusCode(200);
            }
            else
            {
                return StatusCode(400);
            }
        
        }



        // GET api/<Permission>/
        [HttpGet("~/Permission")]
        public IEnumerable<Map> Get1(int ID)
        {
            IServices services = new BusinessLogic();
            List<Map> list = services.ConnectToPermission(ID);
            return list;

        }



        // POST api/<Permission>/id
        [HttpPost("~/PermissionPage1")]
        public bool PermissionPage1(int Id, bool CanCreate, bool CanRead, bool CanWrite, bool CanDelete, bool CanCreate1, bool CanRead1, bool CanWrite1, bool CanDelete1)
        {
            IServices services = new BusinessLogic();
            bool a = services.Complete(Id, CanCreate, CanRead, CanWrite, CanDelete, CanCreate1, CanRead1, CanWrite1, CanDelete1);
            if (a)
            {
                return true;
            }
            else
            {
                return false;
            }

        }




        // POST api/<VCreateUser>
        [HttpPost("~/CreateUser")]
        public bool CreateUser(string Email, string Pass, string Name, int Role)
        {
            IServices services = new BusinessLogic();
            bool a = services.CreatingUser(Email, Pass, Name, Role);
            if (a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
