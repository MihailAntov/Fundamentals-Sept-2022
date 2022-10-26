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
                Person nextPerson = people.Find(n=> n.name == cmdArgs[0]);
                Product nextProduct = products.Find(n => n.name == cmdArgs[1]);

                if (nextProduct.cost > nextPerson.money)
                {
                    Console.WriteLine($"{nextPerson.name} can't afford {nextProduct.name}");
                }
                else
                {
                    Console.WriteLine($"{nextPerson.name} bought {nextProduct.name}");
                    nextPerson.money -= nextProduct.cost;
                    nextPerson.bag.Add(nextProduct);
                }
            }

            foreach(Person person in people)
            {
                Console.Write($"{person.name} - ");
                if(person.bag.Count > 0)
                {
                    Console.Write(String.Join(", ",person.bag.Select(n=>n.name)));
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
            this.name = name;
            this.money = money;
        }
        public List<Product> bag = new List<Product>();
        public string name;
        public decimal money;
    }

    public class Product
    {
        public Product(string name, decimal cost)
        {
            this.name = name;
            this.cost = cost;
        }
        public string name;
        public decimal cost;
    }
}
