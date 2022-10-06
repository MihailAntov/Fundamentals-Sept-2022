using System;

namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string numberAsString = number.ToString();
            int sumOfFactorials = 0;
            for (int i = 0; i < numberAsString.Length; i++)
            {
                int currentDigit = int.Parse(numberAsString[i].ToString());
                int factorial = 1;
                for (int j = 1; j <= currentDigit; j++)
                {
                    factorial *= j;
                }
                sumOfFactorials += factorial;
                factorial = 1;
            }
            if (sumOfFactorials == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
