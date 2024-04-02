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

    public string AddUser(string username, string password, string email)
    {
        if (username.Length < 5 || username.Length > 20)
        {
            Console.WriteLine("Username must be between 5 and 20 characters long.");
            return "Username must be between 5 and 20 characters long.";
        }
        if (Users.Contains(username))
        {
            Console.WriteLine("Expected user registration to fail due to invalid characters in username.");
            return "Expected user registration to fail due to invalid characters in username.";
        }

        if (Users.Contains(username))
        {
            Console.WriteLine("Username already exists.");
            return "Username already exists.";
        }
        if (!Password(password))
        {
            Console.WriteLine("Password lenght must be over 8 characters and must include special sign");
            return "Password lenght must be over 8 characters and must include special sign";
        }
        if (!CheckEmail(email))
        {
            Console.WriteLine("Email must include @gmail.com");
            return "Email must include @gmail.com";
        }

        User newUser = new User(username, password, email);
        Users.Add(username);
        Console.WriteLine("User added successfully.");
        return "User added successfully.";
    }
    public bool Password(string password)
    {
        if (password is not null && password.Length >= 8 && CheckIsCharacterSpecial(password))
        {
            return true;
        }
        return false;

    }
    private bool CheckIsCharacterSpecial(string password)
    {
        foreach (char c in password)
        {
            if (!char.IsLetterOrDigit(c))
            {
                return true;
            }
        }
        return false;
    }
    public bool IsAlphanumeric(string str)
    {
        return str.All(char.IsLetterOrDigit);
    }

    public bool CheckEmail(string email)
    {
        if (email.EndsWith("@gmail.com"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
