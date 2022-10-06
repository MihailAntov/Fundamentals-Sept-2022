using System;

namespace _05.MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            CheckSignOfProduct(num1, num2, num3);
            
        }

        static void CheckSignOfProduct(double num1, double num2, double num3)
        {
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("zero");
                return;
            }
            double[] numbers = new double[3] { num1, num2, num3 };
            int minusCounter = 0;
            foreach (double number in numbers)
            {
                if (number<0)
                {
                    minusCounter++; 
                }
            }

            if (minusCounter % 2 == 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
            
        }
    }
}
