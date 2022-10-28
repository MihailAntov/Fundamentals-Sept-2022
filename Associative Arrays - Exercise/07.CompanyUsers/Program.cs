using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            while ((input = Console.ReadLine())!= "End")
            {
                string[] cmdArgs = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = cmdArgs[0];
                string employeeId = cmdArgs[1];

                if(companies.ContainsKey(companyName))
                {
                    if(companies[companyName].Contains(employeeId))
                    {
                        continue;
                    }
                    companies[companyName].Add(employeeId);
                }
                else
                {
                    companies.Add(companyName, new List<string> { employeeId });
                }
            }

            foreach(KeyValuePair<string, List<string>> company in companies)
            {
                Console.WriteLine(company.Key);
                foreach(string employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }


        }
    }
}
