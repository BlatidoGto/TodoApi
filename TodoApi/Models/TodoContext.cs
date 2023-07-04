using Microsoft.EntityFrameworkCore;


namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContext<TodoContext> options)
            : base(options) 
        {

        }

        public DbSet<TodoContext> TodoItems { get; set; } = null!;
    }
}
