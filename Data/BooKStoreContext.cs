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
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=BookStore;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}