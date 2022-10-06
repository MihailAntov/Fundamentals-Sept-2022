using System;

namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());

            double pricePerCapsule = 0;
            int Days = 0;
            int Capsules = 0;
            double total = 0;
            for (int i = 1; i <= orders; i++)
            {
                pricePerCapsule = double.Parse(Console.ReadLine());
                Days = int.Parse(Console.ReadLine());
                Capsules = int.Parse(Console.ReadLine());
                total += (pricePerCapsule * Capsules) * Days;
                Console.WriteLine($"The price for the coffee is: ${(pricePerCapsule * Capsules) * Days:f2}");
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
