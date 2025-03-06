
namespace DemoMvc.Data
{
    using Microsoft.EntityFrameworkCore;
    using DemoMvc.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //Ánh xạ class Student vào trong csdl tạo ra bảng Students
        public DbSet<Person> Person { get; set; }
    }
}