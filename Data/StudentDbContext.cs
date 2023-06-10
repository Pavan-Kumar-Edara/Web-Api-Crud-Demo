using Microsoft.EntityFrameworkCore;
using StudentCrudApiWithEFCore.Models;

namespace StudentCrudApiWithEFCore.Data
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }

        public DbSet<Student> StudentInfo { get; set; }
    }
}
