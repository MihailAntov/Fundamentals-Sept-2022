using System;
using System.Collections.Generic;

namespace _07.TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> prices = new Dictionary<string, int[]>();
            prices.Add("Weekday", new int[] {12, 18, 12 });
            prices.Add("Weekend", new int[] {15, 20, 15 });
            prices.Add("Holiday", new int[] {5, 12, 10 });

            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if(age<0 || age> 122)
            {
                Console.WriteLine("Error!");
            }
            else if (age <= 18)
            {
                Console.WriteLine($"{prices[day][0]}$");
            }
            else if (age <= 64)
            {
                Console.WriteLine($"{prices[day][1]}$");
            }
            else
            {
                Console.WriteLine($"{prices[day][2]}$");
            }
        }
    }
}
