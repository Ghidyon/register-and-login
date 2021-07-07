using System;

namespace RegisterAndLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Registration Page!");

            // Prompt user to input username
            Console.Write("Enter your username: ");

            // Save username input 
            string username = Console.ReadLine();

            // Prompt user to input password
            Console.Write("Enter your password: ");

            // Save password input
            string password = Console.ReadLine();


            Console.WriteLine("Login Page!");

            string[] loginDetails = new string[2];
            // Require user to login using their username and password
            Console.Write("Enter your username: ");

            // Save username input 
            loginDetails[0] = Console.ReadLine();

            // Prompt user to input password
            Console.Write("Enter your password: ");

            // Save password input
            loginDetails[1] = Console.ReadLine();

            // when login details is incorrect, prompt user to input details again
            while (loginDetails[0] != username || loginDetails[1] != password)
            {
                Console.WriteLine("Invalid login details");
                Console.Write("Do you want to try again? (y or n) ");
                string response = Console.ReadLine();

                if (response == "y" || response == "Y")
                {
                    // Require user to login using their username and password
                    Console.Write("Enter your username: ");

                    // Save username input 
                    loginDetails[0] = Console.ReadLine();

                    // Prompt user to input password
                    Console.Write("Enter your password: ");

                    // Save password input
                    loginDetails[1] = Console.ReadLine();
                }
            }
            
            // Once login details is correct, log user in!
            if (loginDetails[0] == username && loginDetails[1] == password)
            {
                Console.WriteLine("You've successfully logged in!");
            }

        }
    }
}
