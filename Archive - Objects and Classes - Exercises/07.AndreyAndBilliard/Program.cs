using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AndreyAndBilliard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split("-",StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArgs[0];
                decimal price = decimal.Parse(cmdArgs[1]);
                if(!menu.ContainsKey(name))
                {
                    menu.Add(name, 0);
                }

                menu[name] = price;
            }

            List<Customer> customers = new List<Customer>();
            string input;

            while((input = Console.ReadLine())!= "end of clients")
            {
                string[] inputArgs = input.Split("-",StringSplitOptions.RemoveEmptyEntries);
                string customer = inputArgs[0];
                string[] order = inputArgs[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
                string product = order[0];
                int amount = int.Parse(order[1]);

                if(!menu.ContainsKey(product))
                {
                    continue;
                }

                if(!customers
                    .Select(n=>n.Name)
                    .Contains(customer))
                {
                    customers.Add(new Customer(customer));
                }

                Customer currentCustomer = customers.FirstOrDefault(n => n.Name == customer);
                if(!currentCustomer.Purchases.ContainsKey(product))
                {
                    currentCustomer.Purchases.Add(product, 0);
                }
                currentCustomer.Purchases[product] += amount;
                currentCustomer.Bill += menu[product] * amount;
            }

            foreach(Customer customer in customers.OrderBy(n => n.Name))
            {
                Console.WriteLine(customer.Name);
                foreach(KeyValuePair<string, int> purchase in customer.Purchases)
                {
                    Console.WriteLine($"-- {purchase.Key} - {purchase.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:f2}");
            }

            decimal totalBill = customers
                .Select(n => n.Bill)
                .Sum();

            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }

    public class Customer
    {
        private Dictionary<string, int> purchases;
        public Customer(string name)
        {
            Name = name;
            purchases = new Dictionary<string, int>();
        }
        public string Name { get; set; }
       
        public Dictionary<string, int> Purchases { get { return purchases; } }
        
        public decimal Bill { get; set; }
    }
}
