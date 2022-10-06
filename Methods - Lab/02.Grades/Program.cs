using System;

namespace _02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrintGrade(double.Parse(Console.ReadLine())));
        }

        static string PrintGrade(double grade)
        {
            if (grade < 2.00 || grade > 6.00)
            {
                return "";
            }
            else if (grade <3.0)
            {
                return "Fail";
            }
            else if (grade < 3.5)
            {
                return "Poor";
            }
            else if (grade < 4.5)
            {
                return "Good";
            }
            else if (grade < 5.5)
            {
                return "Very good";
            }
            else 
            {
                return "Excellent";
            }
        }
    }
}
