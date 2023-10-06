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
        DbSet<Author> Authors { get; set; }

        DbSet<Book> Books { get; set; }

        DbSet<BookType> BookTypes { get; set; }

        DbSet<Operation> Operations { get; set; }

        DbSet<Student> Students { get; set; }
    }
}
