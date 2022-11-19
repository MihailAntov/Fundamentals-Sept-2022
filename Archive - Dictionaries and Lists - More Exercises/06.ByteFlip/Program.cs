using System;
using System.Collections.Generic;
using System.Linq;
namespace _06.ByteFlip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            input = input.Where(n => n.Length == 2).ToList();
            string[] internalReversed = new string[input.Count];

            for (int i = 0; i < input.Count; i++)
            {
                internalReversed[i] = Reverse(input[i]);
            }

            char[] decoded = new char[internalReversed.Length];

            for (int i = 0; i < internalReversed.Length; i++)
            {
                int hex = int.Parse(internalReversed[internalReversed.Length - 1 - i],System.Globalization.NumberStyles.AllowHexSpecifier);
                decoded[i] = (char)hex;
            }

            Console.WriteLine(String.Join(String.Empty, decoded));




        }

        public static string Reverse(string input)
        {
            char first = input[0];
            char second = input[1];
            string result = string.Concat(second, first);
            return result;
        }
    }
}
