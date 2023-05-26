using Microsoft.EntityFrameworkCore;

namespace Exam.Entities
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<SubjectExam> SubjectExam { get; set; }
    }
}
