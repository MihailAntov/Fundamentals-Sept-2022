using System;
using System.Collections.Generic;

namespace _03.EnglishNameOfLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
               string input = Console.ReadLine();
            string lastChar = input[input.Length - 1].ToString();
            Console.WriteLine(ReturnNameOfLastDigit(int.Parse(lastChar)));
        }

        public static string ReturnNameOfLastDigit(double number)
        {
            int lastDigit = (int)number % 10;
            Dictionary<int, string> namesOfDigits = new Dictionary<int, string> {
                {1, "one" },
                {2, "two" },
                {3, "three" },
                {4, "four" },
                {5, "five" },
                {6, "six" },
                {7, "seven" },
                {8, "eight" },
                {9, "nine" },
                {0, "zero" }
                

            };
            if(namesOfDigits.ContainsKey(lastDigit))
            {
                return namesOfDigits[lastDigit];
            }
            else
            {
                return string.Empty;
            }

            
        }
    }
}
