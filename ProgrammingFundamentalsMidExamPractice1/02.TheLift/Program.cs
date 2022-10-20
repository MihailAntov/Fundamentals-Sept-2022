using System;
using System.Linq;


namespace _02.TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            for (int i = 0; i < wagons.Length; i++)
            {
                for (int j = wagons[i]; j < 4; j++)
                {
                    if (peopleWaiting > 0)
                    {
                        peopleWaiting--;
                        wagons[i]++;
                    }
                    else
                    {
                        
                        break;
                    }
                }

                if (peopleWaiting == 0)
                {
                    break;
                }
                
            }

            if (peopleWaiting > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
            }
            else if (wagons.Any(n => n<4))
            {
                Console.WriteLine("The lift has empty spots!");
            }

            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
