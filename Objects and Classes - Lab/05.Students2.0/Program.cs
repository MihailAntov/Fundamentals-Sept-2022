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
                    if (students[i].FirstName == cmdArgs[0] && students[i].LastName == cmdArgs[1])
                    {
                        studentExists = true;
                        students[i].Age = int.Parse(cmdArgs[2]);
                        students[i].HomeTown = cmdArgs[3];

                        break;
                    }
                }

                if(!studentExists) students.Add(new Student(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), cmdArgs[3]));
                
                
            }

            string queriedCity = Console.ReadLine();

            for (int i =0; i < students.Count(); i++)
            {
                if (students[i].HomeTown == queriedCity)
                {
                    Console.WriteLine($"{students[i].FirstName} {students[i].LastName} is {students[i].Age} years old.");
                }    
            }
        }
    }

    public class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }
    }
}
