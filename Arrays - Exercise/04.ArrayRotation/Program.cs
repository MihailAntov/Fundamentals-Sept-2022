using System;
using System.Linq;

namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i<n; i++)
            {
                //rotate array
                int[] rotated = new int[input.Length];

                for (int j = 0; j < input.Length - 1; j++)
                {
                    rotated[j] = input[j + 1];
                }
                rotated[input.Length - 1] = input[0];
                input = rotated;
            }

            foreach (int number in input)
            {
                Console.Write($"{number} ");
            }
        }
        
    }
}
