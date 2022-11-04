using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);
                if (teams.Any(n => n.TeamCreator == inputArgs[0]))
                {
                    Console.WriteLine($"{inputArgs[0]} cannot create another team!");
                    continue;
                }

                if (teams.Select(n => n.TeamName).ToArray().Contains(inputArgs[1]))
                {
                    Console.WriteLine($"Team {inputArgs[1]} was already created!");
                    continue;
                }


                teams.Add(new Team(inputArgs[0], inputArgs[1]));
                Console.WriteLine($"Team {inputArgs[1]} has been created by {inputArgs[0]}!");

            }
            string input;
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] cmdArgs = input.Split("->", StringSplitOptions.RemoveEmptyEntries);

                if (!teams.Any(n => n.TeamName == cmdArgs[1]))
                {
                    Console.WriteLine($"Team {cmdArgs[1]} does not exist!");
                    continue;
                }

                if (teams.Any(n => n.Members.Contains(cmdArgs[0])) || teams.Any(n => n.TeamCreator == cmdArgs[0]))
                {
                    Console.WriteLine($"Member {cmdArgs[0]} cannot join team {cmdArgs[1]}!");
                    continue;
                }






                teams.Where(n => n.TeamName == cmdArgs[1])
                    .First()
                    .Members
                    .Add(cmdArgs[0]);

            }

            List<Team> teamsToDisband = new List<Team>();
            foreach (Team team in teams.Where(n => n.Members.Count == 0))
            {
                teamsToDisband.Add(team);
            }


            teams.RemoveAll(n => n.Members.Count == 0);
            foreach (Team team in teams.OrderByDescending(n => n.Members.Count).ThenBy(n => n.TeamName))
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.TeamCreator}");

                foreach (string member in team.Members.OrderBy(n => n))
                {
                    Console.WriteLine($"-- {member}");
                }
            }


            Console.WriteLine("Teams to disband:");
            foreach (Team team in teamsToDisband.OrderBy(n => n.TeamName))
            {
                Console.WriteLine(team.TeamName);
            }

            //output


        }
    }

    public class Team
    {
        private List<string> members;
        public Team(string creator, string name)
        {
            TeamCreator = creator;
            TeamName = name;
            members = new List<string>();

        }
        public string TeamCreator { get; set; }
        public string TeamName { get; set; }
        public List<String> Members { get { return members; } set { members = value; } }
        

        
    }


}
