using System;
using System.Linq;

namespace _05.SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(n=>int.Parse(n)).ToArray();
            int sum = 0;
            foreach(int n in numbers)
            {
                if (n % 2 == 0)
                {
                    sum += n;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
