using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace _04.StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            for (int i =0; i < n; i++)
            {
                string input = Console.ReadLine();
                string numberMatchFilter = @"[starSTAR]";
                MatchCollection numberMatches = Regex.Matches(input, numberMatchFilter);

                string decryptedMessage = string.Empty;

                for (int j = 0; j < input.Length; j++)
                {
                    decryptedMessage += (char)((int)input[j] - numberMatches.Count);
                }

                string planetFilter = @"@(?<planet>[a-z|A-Z]+)[^\@\-\!\:\>]*:(?<population>[\d]+)[^\@\-\!\:\>]*!(?<type>[AD])![^\@\-\!\:\>]*->(?<soldiers>[0-9]+)";
                Match planetHit = Regex.Match(decryptedMessage, planetFilter);
                {
                    if(!planetHit.Success)
                    {
                        continue;
                    }
                    string planet = planetHit.Groups["planet"].Value;
                    //int population =int.Parse(planetHit.Groups["population"].Value);
                    string type = planetHit.Groups["type"].Value;
                    //int soldiers = int.Parse(planetHit.Groups["soldiers"].Value);

                    if(type == "D")
                    {
                        destroyedPlanets.Add(planet);
                    }
                    else if (type == "A")
                    {
                        attackedPlanets.Add(planet);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (string planet in attackedPlanets.OrderBy(n => n)) 
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (string planet in destroyedPlanets.OrderBy(n=>n))
            {
                Console.WriteLine($"-> {planet}");
            }


        }
    }
}
