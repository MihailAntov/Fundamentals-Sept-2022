using System;
using System.Linq;
using System.Collections.Generic;
namespace _07.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            int[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            int specialNumber = command[0];
            int power = command[1];
            Detonate(numbers, specialNumber, power);
            Console.WriteLine(numbers.Sum());

        }

        public static void Detonate(List<int> numbers, int specialNumber, int power)
        {
            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specialNumber)
                {
                    int detonationsToTheLeft = Math.Min(power, i);
                    int detonationsToTheRight = Math.Min(power, numbers.Count - 1 - i);

                    for(int j = 0; j < detonationsToTheLeft; j++)
                    {
                        numbers.RemoveAt(i - 1 - j);
                        //indexes reduced by j to account for i moving with each explosion
                    }

                    numbers.RemoveAt(i-detonationsToTheLeft);
                    //index lowered by detonation count to account for i moving after left explosions

                    for (int j = 0; j < detonationsToTheRight; j++)
                    {
                        numbers.RemoveAt(i-detonationsToTheLeft);
                    //index lowered by detonation count to account for i moving after left explosions

                    }
                    i = -1;
                }
            }
        }
    }
}
