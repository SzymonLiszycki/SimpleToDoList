using Microsoft.EntityFrameworkCore;

namespace SimpleToDoList.Models
{
    public class TaskDbContext:DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options)
        {
                
        }
        public DbSet<TaskModel> Tasks { get; set;}
    }
}
