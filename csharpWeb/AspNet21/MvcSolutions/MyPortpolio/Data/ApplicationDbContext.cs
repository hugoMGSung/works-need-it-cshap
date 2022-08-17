using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyPortpolio.Models;

namespace MyPortpolio.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contact { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<Manage> Manages { get; set; }
    }
}
