using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

namespace _08.MentorGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Student> students = new List<Student>();
            while ((input = Console.ReadLine())!= "end of dates")
            {
                string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = inputArgs[0];
                if (!students.Select(n => n.Name).Contains(name))
                {
                    students.Add(new Student(name));
                }

                if (inputArgs.Length == 1)
                {
                    continue;
                }
                DateTime[] dates = inputArgs[1]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => DateTime.ParseExact(n, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                    .ToArray();
                

                
                Student currentStudent = students.First(n => n.Name == name);
                currentStudent.Attendances.AddRange(dates);

                

            }

            while ((input = Console.ReadLine())!= "end of comments")
            {
                string[] inputArgs = input.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string name = inputArgs[0];
                string comment = inputArgs[1];

                if(!students.Select(n => n.Name).Contains(name))
                {
                    continue;
                }
                Student currentStudent = students.First(n => n.Name == name);
                currentStudent.Comments.Add(comment);
            }

            foreach(Student student in students.OrderBy(n=>n.Name))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
               
                foreach(string comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach(DateTime date in student.Attendances.OrderBy(n=>n))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }

            
        }
    }

    public class Student
    {
        private List<DateTime> attendances;
        private List<String> comments;
        public Student(string name)
        {
            Name = name;
            attendances = new List<DateTime>();
            comments = new List<string>();
        }
        public string Name { get; set; }
        public List<DateTime> Attendances { get { return attendances; } }
        public List<string> Comments { get { return comments; } }
    }
}
