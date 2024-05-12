using BCrypt.Net;

public static class HashPasswordByBC
{
    public static string HashPassword(string password)
    {
        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

        return hashedPassword;
    }
    public static bool VerifyPassword(string password, string hashedPassword)
    {
        bool isMatch = BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        return isMatch;
    }


}