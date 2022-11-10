using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PopulationCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();

            while ((input = Console.ReadLine()) != "report")
            {
                string[] inputArgs = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string city = inputArgs[0];
                string country = inputArgs[1];
                long population = long.Parse(inputArgs[2]);

                if(!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, long>());
                }

                if (!countries[country].ContainsKey(city))
                {
                    countries[country].Add(city, 0);
                }

                countries[country][city] += population;
            }

            foreach(KeyValuePair<string, Dictionary<string, long>> country in countries.OrderByDescending(n=>n.Value.Select(n=>n.Value).Sum()))
            {
                long totalPopulation = country.Value.Select(n => n.Value).Sum();
                Console.WriteLine($"{country.Key} (total population: {totalPopulation})");
                foreach(KeyValuePair<string, long> city in country.Value.OrderByDescending(n=>n.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
