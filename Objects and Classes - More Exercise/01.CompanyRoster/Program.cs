using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.CompanyRoster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                employees.Add(new Employee(input[0], decimal.Parse(input[1]), input[2]));
            }
            decimal maxAvgSalary = decimal.MinValue;
            string maxAvgSalaryDepartment = string.Empty;
            List<string> departments = employees.Select(n => n.department).Distinct().ToList();
            foreach(string department in departments)
            {
                decimal avgSalary = employees
                    .Where(n => n.department == department)
                    .Select(n => n.salary)
                    .Sum();

                if (avgSalary > maxAvgSalary)
                {
                    maxAvgSalary = avgSalary;
                    maxAvgSalaryDepartment = department;
                }
            }

            List<Employee> maxAvgSalaryDeptEmployees = employees
                .Where(n => n.department == maxAvgSalaryDepartment)
                .OrderByDescending(n => n.salary)
                .ToList();

            Console.WriteLine($"Highest Average Salary: {maxAvgSalaryDepartment}");
            foreach(Employee employee in maxAvgSalaryDeptEmployees)
            {
                Console.Write($"{employee.name} {employee.salary:f2}\n");
            }

        }
    }

    public class Employee
    {
        public string name;
        public decimal salary;
        public string department;
        public Employee(string name, decimal salary, string department)
        {
            this.name = name;
            this.salary = salary;
            this.department = department;
        }
    }
}
