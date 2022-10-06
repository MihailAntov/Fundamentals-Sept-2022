using System;

namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberBase = double.Parse(Console.ReadLine());
            double numberPower = double.Parse(Console.ReadLine());
            Console.WriteLine(Power(numberBase, numberPower));
        }

        static double Power(double nBase, double nPower)
        {
            if (nPower == 0)
            {
                return 1.0;
            }

            double result = nBase;
            for (int i = 1; i < nPower; i++)
            {
                result *= nBase;
            }

            return result;
        }
    }
}
