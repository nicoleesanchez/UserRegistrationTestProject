using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistration;
using System.Linq;

public class UserRegistrationService
{
    public List<string> Users { get; set; } = new List<string>();

    public bool AddUser(string username, string password, string email)
    {
        if (username.Length < 5 || username.Length > 20)
        {
            Console.WriteLine("Username must be between 5 and 20 characters long.");
            return false;
        }

        if (Users.Contains(username))
        {
            Console.WriteLine("Username already exists.");
            return false;
        }

        User newUser = new User(username, password, email);
        Users.Add(username);
        Console.WriteLine("User added successfully.");
        return true;
    }
    public bool IsAlphanumeric(string str)
    {
        foreach (char c in str)
        {
            if (!char.IsLetterOrDigit(c))
            {
                return false;
            }
        }
        return true;
    }
    public bool Password(string password)
    {
        string specialChar = @"|!#$%&/()=?»«@£§€{}.-;'<>_,";
        foreach (var item in specialChar)
        {
            if (password.Contains(item)) return true;
        }
        return false;
    }
    public bool CheckEmail(string email)
    {
        if (email.EndsWith("@gmail.com"))
        {
            return true;
        }
        else
        {
            throw new ArgumentException("Email must end with ´@gmail.com'");
        }
    }
}
