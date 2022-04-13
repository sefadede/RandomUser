using Microsoft.EntityFrameworkCore;
using RandomUser.Models;

namespace RandomUser.Context
{
    public class TableContext:DbContext
    {
        public TableContext()
        {

        }

        public TableContext(DbContextOptions<TableContext> options) : base(options) { }
        
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"User ID=postgres; Password=zerdali; server=localhost; Port=5432; Database=postgres; Integrated Security=true; Pooling=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
