//using System;
//using System.Text.RegularExpressions;
//using System.Linq;
//namespace _02.DestinationMapper
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();
//            string pattern = @"(=|\/)(?<location>[A-Z][A-Za-z]{2,})\1";
//            Regex regex = new Regex(pattern);

//            MatchCollection matches = regex.Matches(input);

//            Console.WriteLine($"Destinations: {String.Join(", ",matches.Select(n => n.Groups["location"].Value))}");
//            Console.WriteLine($"Travel Points: {matches.Select(n => n.Groups["location"].Value.Length).Sum()}");
//        }
//    }
//}


using System;
using System.Text.RegularExpressions;

namespace _10._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(=|\/)(?<name>[A-Z][A-Za-z]{3,})\1";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matches = Regex.Matches(input, pattern);

            int travelPoints = 0;
            Console.Write("Destinations:");
            foreach (Match match in matches)
            {
                int points = match.Groups["name"].Length;

                travelPoints += points;

                Console.Write($"{string.Join(", ", match.Groups["name"].Value)}");
            }
            Console.WriteLine();
            Console.WriteLine($"Travel Points: {travelPoints}.");
        }
    }
}