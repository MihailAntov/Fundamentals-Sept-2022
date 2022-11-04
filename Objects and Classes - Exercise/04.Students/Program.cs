using System;
using System.Linq;

namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Student[] students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                
                string[] input = Console.ReadLine().Split(' ');
                string firstName = input[0];
                string lastName = input[1];
                double studentGrade = Double.Parse(input[2]);
                students[i] = new Student(firstName, lastName, studentGrade);
            }
            Student[] studentsSorted = students.OrderByDescending(c => c.StudentGrade).ToArray();
            foreach(Student student in studentsSorted)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
    public class Student 
    {
        public Student(string firstName, string lastName, double studentGrade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.StudentGrade = studentGrade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double StudentGrade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {StudentGrade:f2}";
        }

        
    }
}
