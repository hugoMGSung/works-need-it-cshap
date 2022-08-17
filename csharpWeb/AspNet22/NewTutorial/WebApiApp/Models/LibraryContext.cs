using Microsoft.EntityFrameworkCore;

namespace WebApiApp.Models
{
public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
    { }

    public DbSet<Book> Books { get; set; }
}
}
