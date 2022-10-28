using System;
using System.Linq;

namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach(string word in words.Where(n=> n.Length % 2 == 0))
            {
                Console.WriteLine(word);
            }
        }
    }
}
