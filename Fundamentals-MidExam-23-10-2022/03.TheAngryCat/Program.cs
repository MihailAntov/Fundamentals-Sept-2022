using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TheAngryCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> items = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            int entryPoint = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int entryPointValue = items[entryPoint];
            int sumLeft = 0;
            int sumRight = 0;
            List<int> itemsLeft = items.Take(entryPoint).ToList();
            List<int> itemsRight = items.TakeLast(items.Count - 1 - entryPoint).ToList();
            if (type == "cheap")
            {
                
                sumLeft = itemsLeft.Where(n => n < items[entryPoint]).Sum();
                sumRight = itemsRight.Where(n => n < items[entryPoint]).Sum();
            }
            else if (type == "expensive")
            {
                sumLeft = itemsLeft.Where(n => n >= items[entryPoint]).Sum();
                sumRight = itemsRight.Where(n => n >= items[entryPoint]).Sum();
            }

            if(sumLeft >= sumRight)
            {
                Console.WriteLine($"Left - {sumLeft}");
            }
            else
            {
                Console.WriteLine($"Right - {sumRight}");
            }
        }
    }
}
