// Models/User.cs
namespace UserManagerAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public bool IsActive { get; set; }
    }
}