using System;

namespace _05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string numbers = string.Empty;
            string letters = string.Empty;
            string symbols = string.Empty;
            for(int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if(char.IsNumber(currentChar))
                {
                    numbers += currentChar;
                }
                else if (char.IsLetter(currentChar))
                {
                    letters+= currentChar;
                }
                else
                {
                    symbols += currentChar;
                }
            }

            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);

        }
    }
}
