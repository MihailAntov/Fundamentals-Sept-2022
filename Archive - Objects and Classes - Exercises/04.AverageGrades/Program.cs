using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.AverageGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i ++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = cmdArgs[0];
                List<double> grades = cmdArgs.Skip(1).Select(n => double.Parse(n)).ToList();
                students.Add(new Student(name, grades));
                
            }

            foreach(Student student in students.Where(n=>n.AverageGrade >= 5.00).OrderBy(n=>n.Name).ThenByDescending(n=>n.AverageGrade))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }

    public class Student
    {
        public Student(string name, List<double> grades)
        {
            Name = name;
            this.grades = grades;
        }
        public string Name { get; set; }
        public double AverageGrade { get { return Grades.Average(); } }
        public List<double> Grades { get { return grades; } }
        private List<double> grades;
    }
}
