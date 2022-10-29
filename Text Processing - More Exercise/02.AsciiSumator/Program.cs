using System;
using System.Linq;

namespace _02.AsciiSumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = (int)char.Parse(Console.ReadLine());
            int second = (int)char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int start = Math.Min(first, second);
            int end = Math.Max(first, second);
            

            
            int sum = 0;
            foreach(char c in input)
            {
                if(c > start && c <  end)
                sum += (int)c;
            }
            Console.WriteLine(sum);
        }
    }
}
