using MessWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MessWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return MessRepository.Students;
        }
        [HttpGet("{id:int}")]
        public Student GetStudentById(int id)
        {
            return MessRepository.Students.Where(n => n.Id == id).FirstOrDefault();
        }
    }
}
