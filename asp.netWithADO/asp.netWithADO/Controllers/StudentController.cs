using asp.netWithADO.Models;
using asp.netWithADO.Services;
using Microsoft.AspNetCore.Mvc;

namespace asp.netWithADO.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;

        }
        [HttpGet]
        public IActionResult StudentsList()
        {
            AllModels models = new AllModels();
            
            models.studentLists = _studentService.GetStudentsRecord().ToList();
            return View(models);
        }
    }
}
