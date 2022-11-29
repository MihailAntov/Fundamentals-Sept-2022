using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace _02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Racer> results = new List<Racer>();
            string[] racers = Console.ReadLine()
                .Split(", ");

            foreach (string racer in racers)
            {
                results.Add(new Racer(racer, 0));
            }
            string input;
            string digitMatch = @"\d";
            string letterMatch = @"[A-Z]|[a-z]";
            while ((input = Console.ReadLine()) != "end of race")
            {
                MatchCollection digitsMatches = Regex.Matches(input, digitMatch);
                MatchCollection lettersMatches = Regex.Matches(input, letterMatch);
                int[] digitsArray = digitsMatches.Select(n => int.Parse(n.Value)).ToArray();

                string letters = string.Join("", lettersMatches);
                if (results.Select(n => n.Name).Contains(letters))
                {
                    Racer racer = results.FirstOrDefault(n => n.Name == letters);
                    racer.Score += digitsArray.Sum();
                }
            }
            int placeCounter = 0;
            foreach (Racer racer in results.OrderByDescending(n => n.Score))
            {
                placeCounter++;
                switch (placeCounter)
                {
                    case 1:
                        Console.Write("1st");
                        break;
                    case 2:
                        Console.Write("2nd");
                        break;
                    case 3:
                        Console.Write("3rd");
                        break;
                    default:
                        break;
                }

                if (placeCounter <= 3)
                {
                    Console.Write($" place: {racer.Name}\n");
                }

            }
        }
    }

    public class Racer
    {
        public Racer(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public string Name { get; set; }
        public int Score { get; set; }
    }
}



