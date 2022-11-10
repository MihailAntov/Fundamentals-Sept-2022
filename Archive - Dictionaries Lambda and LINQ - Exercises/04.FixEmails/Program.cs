using System;

namespace _04.FixEmails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            while((input = Console.ReadLine()) != "stop")
            {
                string name = input;
                string email = Console.ReadLine();

                string domainEnd = email.Substring(email.Length - 2);

                if(domainEnd.ToLower() != "us" && domainEnd.ToLower() != "uk")
                {
                    Console.WriteLine($"{name} -> {email}");
                }
            }
        }
    }
}
