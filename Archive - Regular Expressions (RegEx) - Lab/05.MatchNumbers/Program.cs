using System;
using System.Text.RegularExpressions;
namespace _05.MatchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))(?<number>\-?\d+(\.{1}\d+)?)($|(?=\s))";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);

            Console.WriteLine(String.Join(" ",matches));
        }
    }
}
