using System;
using System.Linq;
using System.Collections.Generic;
namespace _04.Palindromes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(new char[] {' ',',', '.', '?', '!'},StringSplitOptions.RemoveEmptyEntries);

            string[] filteredWords = words
                .Where(n => IsPalindrome(n))
                .Distinct()
                .OrderBy(n => n)
                .ToArray();

            Console.WriteLine(String.Join(", ",filteredWords));

        }

        public static bool IsPalindrome(string s)
        {
            for (int i = 0; i < s.Length /2; i++)
            {
                if (s[i] != s[s.Length-1-i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
