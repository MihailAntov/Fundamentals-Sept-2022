using System;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(CountVowels(input));
        }

        static int CountVowels(string input)
        {
            int count = 0;
            string vowels = "aeouiy";
            foreach(char c in input)
            {
                if (vowels.Contains(c.ToString().ToLower()))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
