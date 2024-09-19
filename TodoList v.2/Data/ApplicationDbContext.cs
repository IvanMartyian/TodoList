using Microsoft.EntityFrameworkCore;
using TodoList_v._2.Models;

namespace TodoList_v._2.Data
{
    

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
