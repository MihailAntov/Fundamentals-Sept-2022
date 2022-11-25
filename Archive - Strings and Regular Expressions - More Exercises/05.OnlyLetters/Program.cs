using System;
using System.Text.RegularExpressions;

namespace _05.OnlyLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<number>\d+)(?<letter>[A-Za-z])";
            Regex regex = new Regex(pattern);

            
            foreach(Match match in regex.Matches(input))
            {
                string number = match.Groups["number"].Value;
                string letter = match.Groups["letter"].Value;
                input = input.Replace(number, letter);
            }

            Console.WriteLine(input);



        }
    }
}
