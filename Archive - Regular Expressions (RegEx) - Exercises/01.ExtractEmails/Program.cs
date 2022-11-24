using System;
using System.Text.RegularExpressions;
namespace _01.ExtractEmails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(?<=\s)[a-z\d]+([\.\,\-_][a-z\d]+)*@[a-z]+(-[a-z]+)*(\.[a-z]+(-[a-z]+)*)+";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            Console.WriteLine(String.Join(Environment.NewLine, matches));
        }
    }
}
