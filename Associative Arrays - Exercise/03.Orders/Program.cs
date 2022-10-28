using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string input;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string productName = command[0];
                decimal productPrice = Decimal.Parse(command[1]);
                int productQuantity = int.Parse(command[2]);

                if (products.ContainsKey(productName))
                {
                    products[productName].Quantity += productQuantity;
                    products[productName].Price = productPrice;
                }
                else
                {
                    products.Add(productName, new Product(productPrice, productQuantity));
                }
            }

            foreach(KeyValuePair<string, Product> product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value.Quantity * product.Value.Price:f2}");
            }
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
