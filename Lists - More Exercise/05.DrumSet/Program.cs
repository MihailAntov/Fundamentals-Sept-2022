using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.DrumSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal savings = decimal.Parse(Console.ReadLine());

            List<int> drums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> currentDrums = drums.Select(n => n).ToList();
            

            
            string input;

            while ((input = Console.ReadLine())!= "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);

                currentDrums = currentDrums.Select(n => n - hitPower).ToList();

                for (int i = 0; i < drums.Count; i++)
                {
                    if (currentDrums[i] <= 0)
                    {
                        if (drums[i] * 3.0M <= savings)
                        {
                            savings -= 3.0M * drums[i];
                            currentDrums[i] = drums[i];
                        }
                        else
                        {
                            currentDrums.RemoveAt(i);
                            drums.RemoveAt(i);
                        }
                    }
                    
                }

                
            }

            Console.WriteLine(String.Join(" ", currentDrums));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
