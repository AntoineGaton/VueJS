// Controllers/UsersController.cs
// This file contains the API endpoints for user management
// Implements RESTful CRUD operations for the User entity

using Microsoft.AspNetCore.Mvc;
using UserManagerAPI.Data.Repositories;
using UserManagerAPI.Models;

namespace UserManagerAPI.Controllers
{
    /// <summary>
    /// API controller for managing users
    /// Handles HTTP requests for user-related operations
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// Constructor that injects the user repository
        /// Dependency injection provides the repository instance
        /// </summary>
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// GET: api/users
        /// Retrieves all users from the database
        /// </summary>
        /// <returns>List of all users</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _userRepository.GetAllUsersAsync();
            return Ok(users);
        }

        /// <summary>
        /// GET: api/users/{id}
        /// Retrieves a specific user by ID
        /// </summary>
        /// <param name="id">The ID of the user to retrieve</param>
        /// <returns>The user if found, otherwise 404 Not Found</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
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
            var createdUser = await _userRepository.CreateUserAsync(user);
            return CreatedAtAction(nameof(GetUser), new { id = createdUser.Id }, createdUser);
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

            try
            {
                await _userRepository.UpdateUserAsync(user);
                return NoContent();
            }
            catch (Exception)
            {
                return NotFound();
            }
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
            try
            {
                await _userRepository.DeleteUserAsync(id);
                return NoContent();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
