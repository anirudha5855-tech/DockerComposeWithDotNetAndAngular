using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreApisWithDatabase.Data;
using CoreApisWithDatabase.Models;

namespace CoreApisWithDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        ErpDbContext db;
        public StudentController(ErpDbContext db)
        {
            this.db = db;
        }

        [HttpPost]
        public async Task< Student> AddStudent(Student st)
        {
            await db.TblStudents.AddAsync(st);
            await db.SaveChangesAsync();
            return st;
        }
        [HttpGet]
        public async  Task<List<Student>> GetStudents()
        {
            return await db.TblStudents.ToListAsync();
        }

    }
}
