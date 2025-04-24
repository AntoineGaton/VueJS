// Controllers/UsersController.cs
// This file contains the API endpoints for user management
// Implements RESTful CRUD operations for the User entity

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserManagerAPI.Data;
using UserManagerAPI.Models;

namespace UserManagerAPI.Controllers
{
    /// <summary>
    /// API controller for managing users
    /// Handles HTTP requests for user-related operations
    /// </summary>
    [ApiController] // Indicates this is an API controller
    [Route("api/[controller]")] // [controller] is replaced with "Users" from the class name UsersController
    public class UsersController : ControllerBase
    {
        // Database context for performing database operations
        private readonly AppDbContext _context;

        /// <summary>
        /// Constructor that injects the database context
        /// Dependency injection provides the database context instance
        /// </summary>
        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// GET: api/users
        /// Retrieves all users from the database
        /// </summary>
        /// <returns>List of all users</returns>
        [HttpGet]
        // Task<> is used because this is an async method that returns a Promise-like object
        // ActionResult<> allows returning both the data and HTTP status codes (like 404, 400 etc)
        // IEnumerable<User> represents the collection of User objects being returned
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
            => await _context.Users.ToListAsync();

        /// <summary>
        /// GET: api/users/{id}
        /// Retrieves a specific user by ID
        /// </summary>
        /// <param name="id">The ID of the user to retrieve</param>
        /// <returns>The user if found, otherwise 404 Not Found</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            return user == null ? NotFound() : Ok(user);
        }

        /// <summary>
        /// POST: api/users
        /// Creates a new user
        /// </summary>
        /// <param name="user">The user data to create</param>
        /// <returns>The created user with its ID</returns>
        [HttpPost]
        public async Task<ActionResult<User>> CreateUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }

        /// <summary>
        /// PUT: api/users/{id}
        /// Updates an existing user
        /// </summary>
        /// <param name="id">The ID of the user to update</param>
        /// <param name="user">The updated user data</param>
        /// <returns>204 No Content if successful, 400 Bad Request if IDs don't match</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, User user)
        {
            if (id != user.Id) return BadRequest();
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        /// <summary>
        /// DELETE: api/users/{id}
        /// Deletes a user
        /// </summary>
        /// <param name="id">The ID of the user to delete</param>
        /// <returns>204 No Content if successful, 404 Not Found if user doesn't exist</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return NotFound();

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
