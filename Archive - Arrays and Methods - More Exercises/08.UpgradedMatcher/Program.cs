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
            string command;

            while ((command = Console.ReadLine()) != "done")
            {
                int index = -1;
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string product = cmdArgs[0];
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i] == product)
                    {
                        index = i;
                    }
                }

                decimal price = prices[index];
                long quantity = 0;
                long quantityToBeOrdered = long.Parse(cmdArgs[1]);
                

                if(index < quantities.Length)
                {
                    quantity = quantities[index];
                }

                if (quantityToBeOrdered > quantity)
                {
                    Console.WriteLine($"We do not have enough {product}");
                    continue;
                }

                Console.WriteLine($"{product} x {quantityToBeOrdered} costs {quantityToBeOrdered * price:f2}");
                quantities[index] -= quantityToBeOrdered;


            }

        }
    }
}
