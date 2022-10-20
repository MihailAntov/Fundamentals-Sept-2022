using System;

namespace _01.Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int battlesWon = 0;
            string input;

            while ((input = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(input);

                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battlesWon} won battles and {energy} energy");
                    break;
                }
                else
                {
                    energy -= distance;
                    battlesWon++;
                    if(battlesWon % 3 == 0)
                    {
                        energy += battlesWon;
                    }
                }
            }

            if(input == "End of battle")
            {
                Console.WriteLine($"Won battles: {battlesWon}. Energy left: {energy}");
            }
            
        }
    }
}
