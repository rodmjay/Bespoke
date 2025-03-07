namespace TechValley.Rest
{
    public class AuthSettings
    {
        public string Authority { get; set; }
        public string Audience { get; set; }
    }
    
    public class CorsSettings
    {
        public bool AllowAnyOrigin { get; set; } = true;
        public string[] AllowedOrigins { get; set; }
    }
    public class RestSettings
    {
       public AuthSettings Authentication { get; set; }
        public CorsSettings Cors { get; set; }
    }
}
