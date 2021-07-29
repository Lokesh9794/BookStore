using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class BookStoreContext:DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options):base(options)
        {

        }
        public DbSet<Books> Books{get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=lokesh-Inspiron-3542 ;Database=BookStore; Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}