using System;

class Program
{
    static void Main(string[] args)
    {
        int attempts = 3;
        string correctUsernameAdmin = "admin";
        string correctPasswordAdmin = "passworD";
        string correctUsernameJohn = "john";
        string correctPasswordJohn = "pass123";

        while (attempts > 0)
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (username == correctUsernameAdmin && password == correctPasswordAdmin)
            {
                Console.WriteLine("Login successful.");
                break;
            }
            else if (username == correctUsernameJohn && password == correctPasswordJohn)
            {
                Console.WriteLine("Login successful.");
                break;
            }
            else if (username == correctUsernameAdmin || username == correctUsernameJohn)
            {
                Console.WriteLine("Invalid password.");
            }
            else
            {
                Console.WriteLine("Invalid username.");
            }

            attempts--;

            if (attempts == 0)
            {
                Console.WriteLine("Login failed.");
            }
        }

        Console.ReadLine();
    }
}