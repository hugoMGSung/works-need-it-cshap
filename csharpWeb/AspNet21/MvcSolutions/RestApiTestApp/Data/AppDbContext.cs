using Microsoft.EntityFrameworkCore;
using RestApiTestApp.Models;

namespace RestApiTestApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
    }
}
