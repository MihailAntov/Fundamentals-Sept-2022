using System;
using System.Linq;

namespace _04.FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int k = numbers.Length / 4;

            int[] topRow = new int[2*k];
            int[] bottomRow = new int[2*k];

            bottomRow = numbers[k..(3 * k)];

            
            int[] topRowLeft = new int[k];
            int[] topRowRight = new int[k];

            for (int i = 0; i < k; i++)
            {
                topRowLeft[i] = numbers[i];
                topRowRight[i] = numbers[(3*k) + i];

            }
            //topRowLeft = numbers[0..(k-1)];
            Array.Reverse(topRowLeft);
            //topRowRight = numbers[(3*k)..(numbers.Length-1)];
            Array.Reverse(topRowRight);
            topRow = topRowLeft.Concat(topRowRight).ToArray();
            int[] result = new int[2 * k];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = topRow[i] + bottomRow[i];
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
