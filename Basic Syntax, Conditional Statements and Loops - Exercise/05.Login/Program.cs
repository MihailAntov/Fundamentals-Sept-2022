using System;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            int wrongCounter = 0;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            string input = "";
            while (input != password)
            {
                input = Console.ReadLine();

                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                }
                else
                {
                    wrongCounter++;
                    if (wrongCounter == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                    
                }
            }
        }
    }
}
