using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentRecords = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i ++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());
                if (studentRecords.ContainsKey(studentName))
                {
                    studentRecords[studentName].Add(studentGrade);
                }
                else
                {
                    studentRecords.Add(studentName, new List<double> { studentGrade });
                }
            }

            foreach (KeyValuePair<string, List<double>> studentRecord in studentRecords.Where(n=> 1.0 * n.Value.Sum() / n.Value.Count() >= 4.5 ))
            {
                Console.WriteLine($"{studentRecord.Key} -> {1.0 * studentRecord.Value.Sum() / studentRecord.Value.Count():f2}");
            }
        }
    }
}
