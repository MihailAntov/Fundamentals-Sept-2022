using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OldestFamilyMember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person nextMember = new Person(input[0], int.Parse(input[1]));
                family.AddMember(nextMember);
            }

            Person oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.name} {oldestMember.age}");
        }
    }

    public class Family
    {
        public List<Person> people = new List<Person>();
        public void AddMember(Person member)
        {
            people.Add(member);
        }
        public Person GetOldestMember()
        {
            Person maxAgePerson = new Person("", int.MinValue);
            foreach (Person member in people)
            {
                if (member.age > maxAgePerson.age)
                {
                    maxAgePerson = member;
                }
            }

            return maxAgePerson;
        }
    }

    public class Person
    {
        public string name;
        public int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
