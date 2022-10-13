using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
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
            int bombPower = command[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specialNumber)
                {
                    int detonationsToTheLeft = Math.Min(bombPower, i);
                    int detonationsToTheRight = Math.Min(numbers.Count - 1 - i, bombPower);

                    numbers.RemoveRange(i + 1, detonationsToTheRight);
                    numbers.RemoveRange(i - detonationsToTheLeft, detonationsToTheLeft + 1);
                    
                    
                    i = -1;
                }
            }

            Console.WriteLine(numbers.Sum());

        }
    }
}
