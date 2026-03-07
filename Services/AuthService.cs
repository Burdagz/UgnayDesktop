using UgnayDesktop.Data;
using UgnayDesktop.Models;
using BCrypt.Net;

namespace UgnayDesktop.Services;

public class AuthService
{
    public User? Login(string username, string password)
    {
        using var db = new AppDbContext();

        var user = db.Users.FirstOrDefault(u => u.Username == username);

        if (user == null)
            return null;

        bool valid = BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);

        return valid ? user : null;
    }
}