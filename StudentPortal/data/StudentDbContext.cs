using Microsoft.EntityFrameworkCore;
using StudentPortal.Models;

namespace StudentPortal.data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }

        protected StudentDbContext()
        {
        }
        public DbSet<Student> Students { get; set; }
    }


}
