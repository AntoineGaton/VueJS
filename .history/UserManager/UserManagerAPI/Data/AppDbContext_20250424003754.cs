// Data/AppDbContext.cs
// This file defines the database context for Entity Framework Core
// The DbContext is the main class that coordinates Entity Framework functionality

using Microsoft.EntityFrameworkCore;
using UserManagerAPI.Models;

namespace UserManagerAPI.Data
{
    /// <summary>
    /// Database context class that manages database operations
    /// Inherits from DbContext to get Entity Framework Core functionality
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Constructor that takes DbContextOptions
        /// This is required for dependency injection
        /// </summary>
        /// <param name="options">Configuration options for the database context</param>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        /// <summary>
        /// DbSet represents a collection of Users in the database
        /// This property is used to perform CRUD operations on the Users table
        /// Entity Framework Core uses this to create the Users table
        /// </summary>
        public DbSet<User> Users { get; set; }
    }
}
