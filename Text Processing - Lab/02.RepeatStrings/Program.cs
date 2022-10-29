using System;

namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach(string s in input)
            {
                for(int i = 0; i < s.Length; i++)
                {
                    Console.Write(s);
                }
            }
        }
    }
}
