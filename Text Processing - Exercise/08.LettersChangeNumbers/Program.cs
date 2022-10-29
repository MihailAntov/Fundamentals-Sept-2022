using System;

namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.Replace('\t', ' ');

            string[] separatedInput = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            decimal result = 0;
            foreach (string entry in separatedInput)
            {
                char firstLetter = entry[0];
                decimal number = decimal.Parse(entry.Substring(1, entry.Length - 2));
                char secondLetter = entry[entry.Length-1];
                

                if (char.IsUpper(firstLetter))
                {
                    number /= GetAlphabetPosition(firstLetter);
                }
                else
                {
                    number *= GetAlphabetPosition(firstLetter);
                }

                if (char.IsUpper(secondLetter))
                {
                    number -= GetAlphabetPosition(secondLetter);
                }
                else
                {
                    number += GetAlphabetPosition(secondLetter);
                }

                result += number;
            }
            result = Math.Round(result, 2);
            Console.WriteLine($"{result:f2}"); 
        }

        public static int GetAlphabetPosition(char c)
        {
            //string alphabet = "abcdefghijklmnopqrstuvwxyz";

            //return alphabet.IndexOf(c.ToString().ToLower()) + 1;

            return (int)char.ToUpper(c) - 64;
        }
    }
}
