// Models/User.cs
// This file defines the User entity that represents a user in the system
// The User class is used by Entity Framework Core to create the database table

namespace UserManagerAPI.Models
{
    /// <summary>
    /// Represents a user in the system
    /// This class is used as an Entity Framework Core entity
    /// Each property maps to a column in the Users table
    /// </summary>
    public class User
    {
        /// <summary>
        /// Primary key for the User table
        /// Entity Framework Core automatically recognizes this as the primary key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The username of the user
        /// Required field - cannot be null
        /// </summary>
        public required string Username { get; set; }

        /// <summary>
        /// The email address of the user
        /// Required field - cannot be null
        /// </summary>
        public required string Email { get; set; }

        /// <summary>
        /// Indicates whether the user account is active
        /// Default value is false
        /// </summary>
        public bool IsActive { get; set; }
    }
}