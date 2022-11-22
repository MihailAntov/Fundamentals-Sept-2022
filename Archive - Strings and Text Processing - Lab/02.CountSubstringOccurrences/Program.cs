using System;

namespace _02.CountSubstringOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            string pattern = Console.ReadLine().ToLower();

            int count = 0;

            while(input.Contains(pattern))
            {
                input = input.Substring(input.IndexOf(pattern)+1);
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
