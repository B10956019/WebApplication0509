using Microsoft.EntityFrameworkCore;

namespace WebApplication0509.Model
{
    public class TestDB:DbContext
    {
        public TestDB(DbContextOptions<TestDB>options)
            : base(options)
        {

        }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
