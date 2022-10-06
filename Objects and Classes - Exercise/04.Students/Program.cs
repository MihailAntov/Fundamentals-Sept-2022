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
                students[i] = new Student();
                string[] input = Console.ReadLine().Split(' ');
                students[i].firstName = input[0];
                students[i].lastName = input[1];
                students[i].studentGrade = Double.Parse(input[2]);
            }
            Student[] studentsSorted = students.OrderByDescending(c => c.studentGrade).ToArray();
            foreach(Student student in studentsSorted)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
    public class Student 
    {
        public Student()
        {

        }
        public string firstName;
        public string lastName;
        public double studentGrade;

        public override string ToString()
        {
            return $"{firstName} {lastName}: {studentGrade:f2}";
        }

        
    }
}
