using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.SupermarketDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, Product> products = new Dictionary<string, Product>();   
            while ((input = Console.ReadLine()) != "stocked")
            {
                string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = inputArgs[0];
                decimal price = decimal.Parse(inputArgs[1]);
                int quantity = int.Parse(inputArgs[2]);

                if (!products.ContainsKey(name))
                {
                    products.Add(name, new Product(price, 0));
                }

                products[name].Quantity += quantity;
                products[name].Price = price;

            }

            foreach (KeyValuePair<string, Product> product in products)
            {
                Console.WriteLine($"{product.Key}: ${product.Value.Price:f2} * {product.Value.Quantity} = ${product.Value.Quantity * product.Value.Price:f2}");
            }

            Console.WriteLine(new String('-',30));
            decimal grandTotal = products.Values
                .Select(n => n.Quantity * n.Price)
                .Sum();

            Console.WriteLine($"Grand Total: ${grandTotal:f2}");
        }
    }

    public class Product
    {
        public Product(decimal price, int quantity)
        {   
            Price = price;
            Quantity = quantity;
        }

        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
