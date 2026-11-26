using Microsoft.EntityFrameworkCore;
using CoreApisWithDatabase.Models;

namespace CoreApisWithDatabase.Data
{
    public class ErpDbContext:DbContext
    {
        public ErpDbContext(DbContextOptions<ErpDbContext> options):base(options)
        {

        }
        public DbSet<Student> TblStudents { get; set; }
    }
}
