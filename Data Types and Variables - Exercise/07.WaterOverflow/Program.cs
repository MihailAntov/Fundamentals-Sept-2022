using System;

namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentAmount = 0;

            for (int i = 0; i < n; i++)
            {
                int nextAmount = int.Parse(Console.ReadLine());
                if (currentAmount + nextAmount > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    currentAmount += nextAmount;
                }
            }
            Console.WriteLine(currentAmount);
        }
    }
}
