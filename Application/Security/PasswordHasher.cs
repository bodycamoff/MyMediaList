namespace Application.Security;

public class PasswordHasher
{
    public static string HashPassword(string password)
        => BCrypt.Net.BCrypt.HashPassword(password);
}