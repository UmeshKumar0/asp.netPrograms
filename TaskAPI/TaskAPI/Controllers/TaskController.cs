using Microsoft.AspNetCore.Mvc;
using TaskUserAdmin.DataAccess;
using TaskUserAdmin.Models;
using TaskUserAdmin.Service;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpGet]
        public IActionResult Login()  //Login Page
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Verify(Login acc)
        {     //Creating Session after Login and showing Dashboard
            IServices services = new BusinessLogic();
            bool a = services.ConnectToData(acc);
            if (a == true)
            {
                HttpContext.Session.SetString("Email", "Yes");
                return Ok();
            }
            else
            {
                return Unauthorized();
            }
        }

        [HttpGet]
        public IActionResult UserList()      //User List Controller
        {
            IServices services = new BusinessLogic();
            List<Login> list = services.UserList1();
            if (HttpContext.Session.GetString("Email") == "Yes")
            {
                return Ok();
                //return View(list);
            }
            else
            {
                return Unauthorized();
            }
        }
        [HttpGet]
        public IActionResult PermissionPage(int ID) //Permission Page UI
        {
            IServices services = new BusinessLogic();
            List<Map> list = services.ConnectToPermission(ID);
            if (HttpContext.Session.GetString("Email") == "Yes")
            {

                return Ok();
               // ViewBag.Message = Convert.ToString(ID);
               ////  return View(list);
            }
            else
            {
                return Unauthorized();
            }
        }

        [HttpPost]
        public IActionResult PermissionPage1(int Id, bool CanCreate, bool CanRead, bool CanWrite, bool CanDelete, bool CanCreate1, bool CanRead1, bool CanWrite1, bool CanDelete1)  //Permission Page Post
        {
            if (HttpContext.Session.GetString("Email") == "Yes")
            {
                IServices services = new BusinessLogic();
                bool a = services.Complete(Id, CanCreate, CanRead, CanWrite, CanDelete, CanCreate1, CanRead1, CanWrite1, CanDelete1);
                if (a == true)
                {
                    return Ok();
                }
                else
                {
                    return Unauthorized();
                }

            }
            else
            {
                return Unauthorized();
            }
        }
        [HttpGet]
        public IActionResult Dashboard(bool ab)  //Dashboard Ui
        {
            if (HttpContext.Session.GetString("Email") == "Yes")
            {
                if (ab == true)
                {
                    HttpContext.Session.Remove("Email");
                    return Ok();
                }
                else
                {
                    return Unauthorized();
                }
            }
            else
            {
                return Unauthorized();
            }
        }
        [HttpPost]
        public IActionResult CreateUser(string Email, string Pass, string Name, int Role) // Creating New User 
        {

            if (HttpContext.Session.GetString("Email") == "Yes")
            {
                IServices services = new BusinessLogic();
                bool a = services.CreatingUser(Email, Pass, Name, Role);
                if (a == true)
                {
                    return Ok();
                }
                else
                {
                    return Unauthorized();
                }

            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
