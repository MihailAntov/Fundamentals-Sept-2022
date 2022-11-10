using System;
using System.Linq;
using System.Text;
namespace _06.SumReversedNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();
            int[] reversedNumbers = new int[numbers.Length];

            for(int i = 0; i < numbers.Length; i++)
            {
                string currentNumber = numbers[i].ToString();
                StringBuilder strBuilder = new StringBuilder();
                for(int j = currentNumber.Length-1; j>= 0; j--)
                {
                    strBuilder.Append(currentNumber[j]);
                }
                int reversedNumber = int.Parse(strBuilder.ToString());
                reversedNumbers[i] = reversedNumber;
            }

            Console.WriteLine(reversedNumbers.Sum());


        }
    }
}
