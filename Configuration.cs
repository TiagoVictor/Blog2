namespace Blog2;

public static class Configuration
{
    public static string JwtKey = "yRQYnWzskCZUxPwaQupWkiUzKELZ49eM7oWxAQK_ZXw";
    public static string ApiKeyName = "api_key";
    public static string ApiKey = "curso_api_IlTevUmz0ey3NwCVunWg";
    public static SmtpConfiguration Smtp = new();

    public class SmtpConfiguration
    {
        public string Host { get; set; }
        public int Port { get; set; } = 25;
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}