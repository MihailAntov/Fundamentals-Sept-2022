using System;

namespace _01.SantasCookies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalBoxes = 0;
            for (int i = 0; i < n; i++)
            {
                int flour = int.Parse(Console.ReadLine());
                int sugar = int.Parse(Console.ReadLine());
                int cocoa = int.Parse(Console.ReadLine());
                int flourCups = flour / 140;
                int sugarSpoons = sugar / 20;
                int cocoaSpoons = cocoa / 10;

                int totalCookies = (140 + 10 + 20) * Math.Min(flourCups, Math.Min(sugarSpoons, cocoaSpoons)) / 25;

                int boxes = totalCookies / 5;
                totalBoxes += boxes;
                if (boxes == 0)
                {
                    Console.WriteLine($"Ingredients are not enough for a box of cookies.");
                }
                else
                {
                    Console.WriteLine($"Boxes of cookies: {boxes}");
                }
                
                 
            }

            Console.WriteLine($"Total boxes: {totalBoxes}");
        }
    }
}
