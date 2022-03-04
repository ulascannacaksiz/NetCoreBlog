using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAcessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=CoreBlogApiDB;Integrated Security=True;");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
