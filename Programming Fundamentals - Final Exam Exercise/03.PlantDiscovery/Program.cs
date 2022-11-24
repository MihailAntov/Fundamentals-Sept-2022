using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PlantDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();

            for(int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plant = cmdArgs[0];
                int rarity = int.Parse(cmdArgs[1]);
                
                if(!plants.ContainsKey(plant))
                {
                    plants.Add(plant, new Plant(0));
                }
                plants[plant].Rarity = rarity;
            }

            string input;

            while((input = Console.ReadLine())!= "Exhibition")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                string plant = cmdArgs[1];

                if(!plants.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                    continue;
                }

                switch(command)
                {
                    case "Rate:":
                        double rating = double.Parse(cmdArgs[3]);
                        plants[plant].Ratings.Add(rating);
                        break;
                    case "Update:":
                        int newRarity = int.Parse(cmdArgs[3]);
                        plants[plant].Rarity = newRarity;
                        break;
                    case "Reset:":
                        plants[plant].Ratings = new List<double>();
                        break;
                }
            }

            foreach(KeyValuePair<string, Plant> plant in plants)
            {
                if(plant.Value.Ratings.Count == 0)
                {
                    plant.Value.Ratings.Add(0);
                }
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach(KeyValuePair<string, Plant> plant in plants)
                
            {
                double avgRating = plant.Value.Ratings.Average();
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {avgRating:f2}");
            }
        }
    }

    public class Plant
    {
        List<double> ratings;
        public Plant(int rarity)
        {
            Rarity = rarity;
            ratings = new List<double>();
        }

        public int Rarity { get; set; }
        public List<double> Ratings { get { return ratings; } set { ratings = value; } }

    }
}
