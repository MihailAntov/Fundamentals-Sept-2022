using System;
using System.Linq;
using System.Text;

namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            int evenSum = 0;
            int oddSum = 0;
            string evenSumText = "Even: ";
            string oddSumText = "Odd: ";

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    if(evenSumText.Length != 6)
                    {
                        evenSumText += "+";
                    }
                    evenSumText += number;
                    evenSum += number;
                }
                else
                {
                    if (oddSumText.Length != 5)
                    {
                        oddSumText += "+";
                    }
                    oddSumText += number;
                    oddSum += number;
                }
            }

            evenSumText += $" = {evenSum}";
            oddSumText += $" = {oddSum}";

            //Console.WriteLine(evenSumText);
            //Console.WriteLine(oddSumText);
            //Console.WriteLine($"Result: {evenSum} - {oddSum} = {evenSum-oddSum}");
            Console.WriteLine($"{evenSum-oddSum}");

            
        }
    }
}
