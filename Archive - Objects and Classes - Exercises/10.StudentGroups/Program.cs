using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string input;
            List<Town> towns = new List<Town>();
            while ((input = Console.ReadLine()) != "End")
            {
                if (input.Contains("=>"))
                {
                    //town input
                    string[] cmdArgs = input.Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    string[] trimmedCmdArgs = new string[cmdArgs.Length];
                    for (int i = 0; i < cmdArgs.Length; i++)
                    {
                        trimmedCmdArgs[i] = cmdArgs[i].Trim();
                    }

                    string townName = trimmedCmdArgs[0];
                    string[] seatInfo = trimmedCmdArgs[1].Split(' ');
                    int capacity = int.Parse(seatInfo[0]);

                    towns.Add(new Town(townName, capacity));

                }
                else
                {
                    string[] cmdArgs = input.Split('|');
                    string[] trimmedCmdArgs = new string[cmdArgs.Length];
                    for (int i = 0; i < cmdArgs.Length; i++)
                    {
                        trimmedCmdArgs[i] = cmdArgs[i].Trim();
                    }
                    string name = trimmedCmdArgs[0];
                    string email = trimmedCmdArgs[1];
                    DateTime registrationDate = DateTime.ParseExact(trimmedCmdArgs[2], "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    Town currentTown = towns.LastOrDefault();
                    currentTown.Students.Add(new Student(name, email, registrationDate));
                }
            }
            int groupCount = towns.Select(n => n.Groups.Count).Sum();


            Console.WriteLine($"Created {groupCount} groups in {towns.Count} towns:");
            foreach (Town town in towns.OrderBy(n => n.Name))
            {
                foreach (Group group in town.Groups)
                {
                    if (group.Students.Count > 0)
                    {
                        Console.WriteLine($"{town.Name} => {group.PrintGroup()}");
                    }

                }

            }
        }
    }

    public class Student
    {
        public Student(string name, string email, DateTime registrationDate)
        {
            Name = name;
            Email = email;
            RegistrationDate = registrationDate;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    public class Group
    {
        public Group(List<Student> students)
        {
            Students = students;
        }

        public List<Student> Students { get; set; }

        public string PrintGroup()
        {
            return String.Join(", ", Students.Select(n => n.Email));
        }

    }

    public class Town
    {
        public Town(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Students = new List<Student>();

        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Student> Students { get; set; }
        public List<Group> Groups { get { return GetGroups(this.Students); } }

        public List<Group> GetGroups(List<Student> students)
        {
            List<Group> groups = new List<Group>();
            students = students
                .OrderBy(n => n.RegistrationDate)
                .ThenBy(n => n.Name)
                .ThenBy(n => n.Email.Substring(0, n.Email.IndexOf('@')))
                .ToList();

            while (students.Count > 0)
            {
                groups.Add(new Group(students.Take(Capacity).ToList()));
                students = students.Skip(Capacity).ToList();
            }
            if (groups.Count == 0)
            {
                groups.Add(new Group(new List<Student>()));
            }
            return groups;
        }
    }
}
