using Microsoft.AspNetCore.Mvc;

namespace NzedWalks.Controller
{

    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetAllStudents()
        {

            string[] students = new string[] { "Samuel", "John", "Doe" };
            return Ok(students);
        }
    }
}