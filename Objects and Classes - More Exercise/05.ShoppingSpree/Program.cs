using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShoppingSpree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string[] peopleInput = Console.ReadLine()
                .Split(";");
            foreach(string s in peopleInput)
            {
                string[] personDetails = s.Split("=",StringSplitOptions.RemoveEmptyEntries);
                string personName = personDetails[0];
                decimal personMoney = decimal.Parse(personDetails[1]);

                people.Add(new Person(personName, personMoney));
            }

            List<Product> products = new List<Product>();
            string[] productInput = Console.ReadLine()
                .Split(";",StringSplitOptions.RemoveEmptyEntries);

            foreach(string s in productInput)
            {
                string[] productDetails = s.Split("=",StringSplitOptions.RemoveEmptyEntries);
                string productName = productDetails[0];
                decimal productCost = decimal.Parse(productDetails[1]);

                products.Add(new Product(productName, productCost));
            }

            string input;
            while ((input = Console.ReadLine())!= "END")
            {
                string[] cmdArgs = input.Split(" ");
                Person nextPerson = people.Find(n=> n.Name == cmdArgs[0]);
                Product nextProduct = products.Find(n => n.Name == cmdArgs[1]);

                if (nextProduct.Cost > nextPerson.Money)
                {
                    Console.WriteLine($"{nextPerson.Name} can't afford {nextProduct.Name}");
                }
                else
                {
                    Console.WriteLine($"{nextPerson.Name} bought {nextProduct.Name}");
                    nextPerson.Money -= nextProduct.Cost;
                    nextPerson.bag.Add(nextProduct);
                }
            }

            foreach(Person person in people)
            {
                Console.Write($"{person.Name} - ");
                if(person.bag.Count > 0)
                {
                    Console.Write(String.Join(", ",person.bag.Select(n=>n.Name)));
                }
                else
                {
                    Console.Write("Nothing bought");
                }
                Console.WriteLine();
            }

        }
    }

    public class Person
    {
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
        }
        public List<Product> bag = new List<Product>();
        public string Name { get; set; }
        public decimal Money { get; set; }
    }

    public class Product
    {
        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }
        public string Name { get; set; }
        public decimal Cost { get; set; }
    }
}
