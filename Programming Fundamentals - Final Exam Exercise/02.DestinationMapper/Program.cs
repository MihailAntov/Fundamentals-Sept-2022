using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace _02.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(=|\/)(?<location>[A-Z][A-Za-z]{2,})\1";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            Console.WriteLine($"Destinations: {String.Join(", ",matches.Select(n => n.Groups["location"].Value))}");
            Console.WriteLine($"Travel Points: {matches.Select(n => n.Groups["location"].Value.Length).Sum()}");
        }
    }
}
