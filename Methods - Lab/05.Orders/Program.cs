using System;

namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine($"{CalculatePrice(product, quantity):f2}");

        }

        static decimal CalculatePrice(string product, int quantity)
        {
            

            switch(product)
            {
                case "coffee":
                    return quantity * 1.50M;
                case "water":
                    return quantity * 1.00M;
                case "coke":
                    return quantity * 1.40M;
                case "snacks":
                    return quantity * 2.0M;
                default:
                    return 0.0m;
            }
        }
    }
}
