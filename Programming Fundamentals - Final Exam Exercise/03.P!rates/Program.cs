using System;
using System.Collections.Generic;

namespace _03.P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, City> cities = new Dictionary<string, City>();
            while ((input = Console.ReadLine())!= "Sail")
            {
                string[] inputArgs = input.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string city = inputArgs[0];
                int population = int.Parse(inputArgs[1]);
                int gold = int.Parse(inputArgs[2]);

                if(!cities.ContainsKey(city))
                {
                    cities.Add(city, new City(0, 0));
                }

                cities[city].Population += population;
                cities[city].Gold += gold;
            }

            while((input = Console.ReadLine())!= "End")
            {
                string[] inputArgs = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string command = inputArgs[0];
                string cityName = inputArgs[1];
                City city = cities[cityName];

                if(command == "Plunder")
                {
                    int people = int.Parse(inputArgs[2]);
                    int gold = int.Parse(inputArgs[3]);
                    city.Population -= people;
                    city.Gold -= gold;
                    Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {people} citizens killed.");
                    if(city.Population == 0 || city.Gold == 0)
                    {
                        Console.WriteLine($"{cityName} has been wiped off the map!");
                        cities.Remove(cityName);
                    }

                }
                else if (command == "Prosper")
                {
                    int gold = int.Parse(inputArgs[2]);
                    if(gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    city.Gold += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {cityName} now has {city.Gold} gold.");
                }
            }

            if(cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach(KeyValuePair<string, City> city in cities)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value.Population} citizens, Gold: {city.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }

    public class City
    {
        public City(int population, int gold)
        {
            
            Population = population;
            Gold = gold;
        }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
}
