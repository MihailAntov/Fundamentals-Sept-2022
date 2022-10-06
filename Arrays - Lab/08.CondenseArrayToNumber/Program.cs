using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            int rounds = numbers.Length;

            while (numbers.Length > 1)
            {
                int[] condensed = new int[numbers.Length - 1];
                for (int j = 0; j < numbers.Length-1; j++)
                {
                   condensed[j] = numbers[j] + numbers[j + 1];
                }
                numbers = condensed;
            }
            Console.WriteLine(numbers[0]);

            

        }
        
    }
}
