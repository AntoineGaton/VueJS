namespace UserManagerAPI.Models
{
    public class DatabaseSettings
    {
        public string DefaultConnection { get; set; } = string.Empty;
    }

    public class JwtSettings
    {
        public string SecretKey { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
        public int ExpiryInMinutes { get; set; }
    }

    public class AppSettings
    {
        public DatabaseSettings Database { get; set; } = new();
        public JwtSettings Jwt { get; set; } = new();
    }
}