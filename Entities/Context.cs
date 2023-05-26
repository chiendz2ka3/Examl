using Microsoft.EntityFrameworkCore;

namespace Exam.Entities
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<SubjectExam> SubjectExam { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        public DbSet<ClassRoom> classroom { get; set; }
        public DbSet<Faculty> faculty { get; set; }
    }
}
