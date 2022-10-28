using System;
using System.Collections.Generic;
namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine())!= "end")
            {
                string[] cmdArgs = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = cmdArgs[0];
                string studentName = cmdArgs[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string> { studentName });
                }
                else
                {
                    courses[courseName].Add(studentName);
                }
            }

            foreach(KeyValuePair<string, List<String>> course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach(string student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }

            
        }
    }

   
}
