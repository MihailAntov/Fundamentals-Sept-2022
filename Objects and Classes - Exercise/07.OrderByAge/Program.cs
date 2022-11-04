using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Person> people = new List<Person>();
            while ((input = Console.ReadLine())!= "End")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (people.Select(n => n.ID).Contains(cmdArgs[1]))
                {
                    Person personBeingEditted = people.Find(n=> n.ID == cmdArgs[1]);
                    personBeingEditted.Name = cmdArgs[0];
                    personBeingEditted.Age = int.Parse(cmdArgs[2]);
                }
                else
                {
                    people.Add(new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2])));
                }
            }

            foreach(Person person in people.OrderBy(n=>n.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }

    public class Person
    {
        public Person(string name, string iD, int age)
        {
            this.Name = name;
            this.ID = iD;
            this.Age = age;
        }
        public string Name { get; set; }
        public string ID { get;  private set; }
        public int Age { get;  set; }
        
    }
}
