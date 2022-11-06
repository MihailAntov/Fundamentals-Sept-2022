using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.ImmuneSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = int.Parse(Console.ReadLine());
            int startingHealth = health;
            string virus;
            List<String> encounteredViruses = new List<string>();

            while ((virus = Console.ReadLine())!= "end")
            {
                int strength = virus
                    .ToCharArray()
                    .Select(n => (int)n)
                    .Sum() / 3;

                
                int time = virus.Length * strength;
                if (encounteredViruses.Contains(virus))
                {
                    time /= 3;
                }

                Console.WriteLine($"Virus {virus}: {strength} => {time} seconds");

                int minutes = time / 60;
                int seconds = time % 60;

                if(health >= time)
                {
                    Console.WriteLine($"{virus} defeated in {minutes}m {seconds}s.");
                    health -= time;
                    Console.WriteLine($"Remaining health: {health}");
                    health = (int)Math.Min(1.2 * health, startingHealth);
                    if(!encounteredViruses.Contains(virus))
                    {
                        encounteredViruses.Add(virus);
                    }
                }
                else
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }
                
            }

            Console.WriteLine($"Final Health: {health}");
        }
    }
}
