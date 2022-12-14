using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Student> students = new List<Student>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                students.Add(new Student(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), cmdArgs[3]));
            }

            string queriedCity = Console.ReadLine();

            foreach(Student student in students.Where(student => student.homeTown == queriedCity))
            {
                Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");
            }
        }
    }

    public class Student
    {
        public string firstName;
        public string lastName;
        public int age;
        public string homeTown;

        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.homeTown = homeTown;
        }
    }
}
