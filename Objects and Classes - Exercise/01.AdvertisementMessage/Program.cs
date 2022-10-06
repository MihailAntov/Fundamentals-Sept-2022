using System;
using System.Collections.Generic;

namespace _01.AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> phrases = new List<String> { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            List<String> Events = new List<String> { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            List<String> Authors = new List<String> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<String> Cities = new List<String> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            void GenerateAdvertisement(int n)
            {
                Random random = new Random();
                for (int i = 0; i <n; i++)
                {
                    Console.WriteLine($"{phrases[random.Next(0,phrases.Count-1)]} " +
                        $"{Events[random.Next(0, Events.Count - 1)]} " +
                        $"{Authors[random.Next(0, Authors.Count - 1)]} - " +
                        $"{Cities[random.Next(0, Cities.Count - 1)]}");
                }
            }

            GenerateAdvertisement(int.Parse(Console.ReadLine()));

            
        }
    }
    
}
