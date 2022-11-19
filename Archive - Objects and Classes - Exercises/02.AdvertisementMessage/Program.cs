using System;

namespace _02.AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i ++)
            {
                Console.WriteLine($"{phrases[random.Next(phrases.Length)]} {events[random.Next(events.Length)]} {authors[random.Next(authors.Length)]} - {cities[random.Next(cities.Length)]}");
            }
        }
    }
}
