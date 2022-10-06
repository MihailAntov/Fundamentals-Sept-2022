using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            int maxValue = 0;
            int maxAmount = 0;
            int currentAmount = 0;
            int currentValue = 0;
            int previousValue = 0;
            string result = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                currentValue = numbers[i];
                if(currentValue != previousValue)
                {
                    currentAmount = 0;
                }
                currentAmount++;

                if(currentAmount > maxAmount)
                {
                    maxValue = currentValue;
                    maxAmount = currentAmount;
                }

                previousValue = currentValue;

            }
            
            for (int i = 0; i < maxAmount; i++)
            {
                if (i != 0)
                {
                    result += " ";
                }
                result += maxValue;
            }
            Console.WriteLine(result);
        }
    }
}
