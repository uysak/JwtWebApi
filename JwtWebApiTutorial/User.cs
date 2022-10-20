namespace JwtWebApiTutorial
{
    public class User
    {
        public string Username { get; set; }
        public byte[] PasswordHash{ get; set; }
        public byte[] PasswordSalt { get; set; }
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime TokenCreated { get; set; } = DateTime.Now;
        public DateTime TokenExpires { get; set; }
    }
}
