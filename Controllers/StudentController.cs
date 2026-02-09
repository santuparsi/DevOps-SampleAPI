using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public StudentController() { }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "student1", "student2", "student3" };
        }
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "student";
        }
    }
}
