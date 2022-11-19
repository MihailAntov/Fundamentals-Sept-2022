using System;
using System.Collections.Generic;
using System.Linq;  
namespace _01.OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Person> people = new List<Person>();
            while((input = Console.ReadLine())!= "End")
            {
                string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = inputArgs[0];
                string id = inputArgs[1];
                int age = int.Parse(inputArgs[2]);
                people.Add(new Person(name, id, age));
            }

            foreach(Person person in people.OrderBy(n=>n.Age))
            {
                Console.WriteLine(person);
            }
        }
    }

    public class Person
    {
        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
