using System;
using System.Text.RegularExpressions;
namespace _06.ExtractEmails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string emailFilter = @"(?<=\s)([\da-zA-Z]+[-\._])*[\da-zA-Z]+\@([a-zA-Z-]+\.)+([a-zA-Z\-]+)";
            MatchCollection emails = Regex.Matches(input, emailFilter);
            foreach(Match email in emails)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
