using System;
using System.Linq;
namespace _04.GrabAndGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] ints = Console.ReadLine()
                .Split(' ')
                .Select(n=> long.Parse(n))
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            int lastIndex = -1;

            for (int i = ints.Length-1; i >= 0; i--)
            {
                if(ints[i] == n)
                {
                    lastIndex = i;
                    break;
                }
            }

            if(lastIndex == -1)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                Console.WriteLine((long)ints[0..lastIndex].Sum());
            }
        }
    }
}
