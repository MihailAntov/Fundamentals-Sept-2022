using System;

namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {

                Console.WriteLine(CheckIfPalindrome(input)); 
            }
        }

        static bool CheckIfPalindrome (string input)
        {
            string inputReversed = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                inputReversed += input[i];
            }

            int number = int.Parse(input);
            int numberReversed = int.Parse(inputReversed);

            if (number == numberReversed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
