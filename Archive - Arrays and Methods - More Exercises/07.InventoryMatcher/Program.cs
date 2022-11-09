using System;
using System.Linq;
namespace _07.InventoryMatcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            long[] quantities = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => long.Parse(n))
                .ToArray();

            decimal[] prices = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => decimal.Parse(n))
                .ToArray();
            string product;

            while((product = Console.ReadLine())!= "done")
            {
                int index = -1;
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i] == product)
                    {
                        index = i;
                    }
                }

                Console.WriteLine($"{products[index]} costs: {prices[index]}; Available quantity: {quantities[index]}");
            }
            
        }
    }
}
