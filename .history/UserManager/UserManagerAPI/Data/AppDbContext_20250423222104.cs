// Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using UserManagerAPI.Models;

namespace UserManagerAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<User> Users { get; set; }
    }
}
