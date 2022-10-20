using System;

namespace _01.BlackFlag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            decimal plunderPerDay = decimal.Parse(Console.ReadLine()); 
            decimal expectedPlunder = decimal.Parse(Console.ReadLine());
            decimal totalPlunder = 0;
            for (int day = 1; day <= days; day++)
            {
                totalPlunder += plunderPerDay;
                if (day % 3 == 0)
                {
                    totalPlunder += plunderPerDay / 2.0M;
                }

                if (day % 5 == 0)
                {
                    totalPlunder *= 0.7M;
                }
            }

            if (totalPlunder < expectedPlunder)
            {
                Console.WriteLine($"Collected only {(totalPlunder/expectedPlunder) * 100.0M:f2}% of the plunder.");
            }
            else
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
        }
    }
}
