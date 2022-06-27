using Microsoft.AspNetCore.Mvc;
using StudentAPI.Model;

namespace StudentAPI.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbContext _context;

        public StudentController(StudentDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("api/[controller]s")]
        public ActionResult<List<Student>> GetAll()
        {
            List<Student> students = new List<Student>();
            students = _context.Students.ToList();
            return students;
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public ActionResult<Student> GetById(int id)
        {
            Student student = new Student();
            student = _context.Students.Find(id);
            return student;
        }

        [HttpPost]
        [Route("api/[controller]/")]
        public ActionResult AddStudent(Student student)
        {
            _context.Add(student);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        [Route("api/[controller]/")]
        public ActionResult UpdateStudent(Student student)
        {
            _context.Update(student);
            _context.SaveChanges();
            return Ok();
        }


        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public ActionResult DeleteStudent(int id)
        {
            Student student = _context.Students.Find(id);
            _context.Students.Remove(student);
            _context.SaveChanges();
            return Ok();
        }
    }
}
