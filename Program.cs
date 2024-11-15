using System;
using System.Collections;

class UserAccount
{
    public string Email { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public UserAccount(string email, string username, string password)
    {
        Email = email;
        Username = username;
        Password = password;
    }
    public UserAccount(UserAccount other)
    {
        Email = other.Email;
        Username = other.Username;
        Password = other.Password;
    }
    public bool CheckCredentials(string username, string password)
    {
        return Username == username && Password == password;
    }
}
class Program
{
    static void Main(string[] args)
    {
        ArrayList accounts = new ArrayList();
        UserAccount account1 = new UserAccount("user1@example.com", "user1", "pass1");
        UserAccount account2 = new UserAccount("user2@example.com", "user2", "pass2");
        accounts.Add(account1);
        accounts.Add(account2);
        UserAccount accountCopy = new UserAccount(account1);
        accounts.Add(accountCopy);
        Console.WriteLine("Enter Username:");
        string inputUsername = Console.ReadLine();
        Console.WriteLine("Enter Password:");
        string inputPassword = Console.ReadLine();
        bool credentialsValid = false;
        foreach (UserAccount account in accounts)
        {
            if (account.CheckCredentials(inputUsername, inputPassword))
            {
                Console.WriteLine("Correct credentials.");
                credentialsValid = true;
                break;
            }
        }

        if (!credentialsValid)
        {
            Console.WriteLine("Invalid credentials.");
        }
    }
}
