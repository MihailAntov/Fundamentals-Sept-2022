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
                if (people.Select(n => n.iD).Contains(cmdArgs[1]))
                {
                    Person personBeingEditted = people.Find(n=> n.iD == cmdArgs[1]);
                    personBeingEditted.name = cmdArgs[0];
                    personBeingEditted.age = int.Parse(cmdArgs[2]);
                }
                else
                {
                    people.Add(new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2])));
                }
            }

            foreach(Person person in people.OrderBy(n=>n.age))
            {
                Console.WriteLine($"{person.name} with ID: {person.iD} is {person.age} years old.");
            }
        }
    }

    public class Person
    {
        public string name;
        public string iD;
        public int age;
        public Person(string name, string iD, int age)
        {
            this.name = name;
            this.iD = iD;
            this.age = age;
        }
    }
}
