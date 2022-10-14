using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            string textAsString = Console.ReadLine();
            List<char> text = textAsString.ToList();
            string message = String.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                int index =  GetDigitSum(numbers[i]) % text.Count;
                message += text[index];
                text.RemoveAt(index);
                
                
            }

            Console.WriteLine(message);



        }

        static int GetDigitSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            sum += number % 10;
            return sum;
        }
    }
}
