using Microsoft.EntityFrameworkCore;

namespace ToDoApi
{
    public class ToDoDb : DbContext
    {
        public ToDoDb(DbContextOptions options) : base(options) { }
        public DbSet<ToDoItem> Todos { get; set; }

    }
}
