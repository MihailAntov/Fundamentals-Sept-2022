using System;
using System.Linq;

namespace _09.JumpAround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(n=> int.Parse(n))
                .ToArray();
            int sum = 0;
            TryToMove(0, ints, ref sum);
            Console.WriteLine(sum);


        }

        public static void TryToMove(int currentIndex, int[] ints, ref int sum)
        {
            if(currentIndex >= ints.Length || currentIndex < 0)
            {
                return;
            }

            int currentValue = ints[currentIndex];
            sum += ints[currentIndex];

            if(currentIndex + currentValue < ints.Length)
            {
                TryToMove(currentIndex + currentValue, ints, ref sum);
            }
            else if (currentIndex - currentValue >= 0)
            {
                TryToMove(currentIndex - currentValue, ints, ref sum);
            }
            else
            {
                return;
            }
        }
    }
}
