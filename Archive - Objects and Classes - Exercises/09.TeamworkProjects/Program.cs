using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();    
            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);
                string name = inputArgs[0];
                string team = inputArgs[1];

                if(teams.Select(n=>n.Name).Contains(team))
                {
                    Console.WriteLine($"Team {team} was already created!");
                    continue;
                }

                if(teams.Select(n=>n.Creator).Contains(name))
                {
                    Console.WriteLine($"{name} cannot create another team!");
                    continue;
                }

                teams.Add(new Team(team, name));
                Console.WriteLine($"Team {team} has been created by {name}!");

            }

            string input;

            while((input = Console.ReadLine())!= "end of assignment")
            {
                string[] inputArgs = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string name = inputArgs[0];
                string team = inputArgs[1];

                

                if (!teams.Select(n=>n.Name).Contains(team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    continue;
                }

                if (teams.Any(n => n.Creator == name) ||
                    teams.Any(n=>n.Members.Contains(name)))
                {
                    Console.WriteLine($"Member {name} cannot join team {team}!");
                    continue;
                }

                Team currentTeam = teams.FirstOrDefault(n=>n.Name == team);
                currentTeam.Members.Add(name);
                
            }

            foreach(Team team in teams
                .Where(n=>n.Members.Count>0)
                .OrderByDescending(n=>n.Members.Count)
                .ThenBy(n=>n.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                foreach(string member in team.Members.OrderBy(n=>n))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach(Team team in teams.Where(n=>n.Members.Count == 0).OrderBy(n=>n.Name))
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    public class Team
    {
        private List<string> members;
        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            members = new List<string>();
        }
        public string Name { get; set; }    
        public string Creator { get; set; }
        public List<string> Members { get { return members; } }
    }
}
