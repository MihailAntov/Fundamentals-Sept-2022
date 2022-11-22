using System;

namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] {' ','\t'},StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach(string s in input)
            {
                char firstLetter = s[0];
                int digit = int.Parse(s.Substring(1,s.Length-2));
                char secondLetter = s[s.Length-1];
                double result = (double)digit;
                if(char.IsUpper(firstLetter))
                {
                    result = 1.0 * result / Position(char.ToUpper(firstLetter));
                }
                else
                {
                    result = 1.0 * result * Position(char.ToUpper(firstLetter));
                }

                if (char.IsUpper(secondLetter))
                {
                    result = 1.0 * result - Position(char.ToUpper(secondLetter));
                }
                else
                {
                    result = 1.0 * result + Position(char.ToUpper(secondLetter));
                }

                sum += result;
            }
            
            Console.WriteLine($"{Math.Round(sum,2,MidpointRounding.ToEven):f2}");
        }

        static int Position(char c)
        {
            int result = (int)(c - 64);
            return result;
        }
    }
}
