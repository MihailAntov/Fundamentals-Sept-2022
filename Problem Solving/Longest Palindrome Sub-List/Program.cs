using System;

namespace Longest_Palindrome_Sub_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(FindLongestPalindrome(input));
            
        }

        public static int FindLongestPalindrome(string input)
        {
            for (int i = input.Length; i > 0; i--)
            {
                if(FindLongestPalindromeWithLength(input, i) != 0)
                {
                    return (FindLongestPalindromeWithLength(input, i));
                }
                
            }
            return 0;
        }

        public static int FindLongestPalindromeWithLength(string input, int length)
        {
            for (int i = 0; i <= input.Length - length; i++)
            {
                string currentSubstring = input.Substring(i, length);
                if(IsPalindrome(currentSubstring))
                {
                    return length;
                }
            }
            return 0;
        }

        public static bool IsPalindrome(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != input[input.Length -1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
