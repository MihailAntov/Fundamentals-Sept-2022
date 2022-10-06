using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                int[] nextPair = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

                if (i % 2 == 0)
                {
                    firstArray[i] = nextPair[0];
                    secondArray[i] = nextPair[1];
                }
                else
                {
                    firstArray[i] = nextPair[1];
                    secondArray[i] = nextPair[0];
                }
            }
            

            foreach (int i in firstArray)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            foreach (int i in secondArray)
            {
                Console.Write(i + " ");
            }
        }
    }
}
