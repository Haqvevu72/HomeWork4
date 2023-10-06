using HomeWork4.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeWork4.Contexts
{
    public class LibraryDb:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=STHQ0128-08;Database=LibraryDb;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<BookType> BookTypes { get; set; }

        public DbSet<Operation> Operations { get; set; }

        public DbSet<Student> Students { get; set; }
    }
}
