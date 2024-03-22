using Microsoft.EntityFrameworkCore;
using Todo.Entitys;

namespace Todo.DataContex
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }
        public DbSet<ListToDo> listToDos { get; set; }
        public DbSet<User> users { get; set; }
    }
}
