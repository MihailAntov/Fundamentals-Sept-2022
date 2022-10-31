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
                bool studentExists = false;
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].firstName == cmdArgs[0] && students[i].lastName == cmdArgs[1])
                    {
                        studentExists = true;
                        students[i].age = int.Parse(cmdArgs[2]);
                        students[i].homeTown = cmdArgs[3];

                        break;
                    }
                }

                if(!studentExists) students.Add(new Student(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), cmdArgs[3]));
                
                
            }

            string queriedCity = Console.ReadLine();

            for (int i =0; i < students.Count(); i++)
            {
                if (students[i].homeTown == queriedCity)
                {
                    Console.WriteLine($"{students[i].firstName} {students[i].lastName} is {students[i].age} years old.");
                }    
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
