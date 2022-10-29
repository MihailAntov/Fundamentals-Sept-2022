using System;

namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string a = input[0];
            string b = input[1];
            Console.WriteLine(SumCharacters(a, b));
        }

        public static int SumCharacters(string a, string b)
        {
            int lengthOfShorter = Math.Min(a.Length, b.Length);
            int lengthOfLonger = Math.Max(a.Length, b.Length);
            int result = 0;
            for (int i = 0; i < lengthOfShorter; i++)
            {
                result += a[i] * b[i];
            }
            string longerString = string.Empty;
            if(a.Length>b.Length)
            {
                longerString = a;
            }
            else
            {
                longerString = b;
            }

            for (int i = lengthOfShorter; i < lengthOfLonger; i++)
            {
                result += longerString[i];
            }
            
            return result;
        }
    }
}
