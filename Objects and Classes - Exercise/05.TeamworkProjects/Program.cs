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
                if(teams.Any(n=> n.teamCreator == inputArgs[0]))
                {
                    Console.WriteLine($"{inputArgs[0]} cannot create another team!");
                    continue;
                }

                if(teams.Select(n=> n.teamName).ToArray().Contains(inputArgs[1]))
                {
                    Console.WriteLine($"Team {inputArgs[1]} was already created!");
                    continue;
                }


                teams.Add(new Team(inputArgs[0], inputArgs[1]));
                Console.WriteLine($"Team {inputArgs[1]} has been created by {inputArgs[0]}!");

            }
            string input;
            while ((input = Console.ReadLine())!= "end of assignment")
            {
                string[] cmdArgs = input.Split("->", StringSplitOptions.RemoveEmptyEntries);

                if (!teams.Any(n => n.teamName == cmdArgs[1]))
                {
                    Console.WriteLine($"Team {cmdArgs[1]} does not exist!");
                    continue;
                }

                if (teams.Any(n => n.members.Contains(cmdArgs[0])) || teams.Any(n=>n.teamCreator == cmdArgs[0]))
                {
                    Console.WriteLine($"Member {cmdArgs[0]} cannot join team {cmdArgs[1]}!");
                    continue;
                }

                




                teams.Where(n => n.teamName == cmdArgs[1])
                    .First()
                    .members
                    .Add(cmdArgs[0]);

            }
            
            List<Team> teamsToDisband = new List<Team>();
            foreach(Team team in teams.Where(n=> n.members.Count == 0))
            {
                teamsToDisband.Add(team);
            }


            teams.RemoveAll(n => n.members.Count == 0);
            foreach (Team team in teams.OrderByDescending(n=> n.members.Count).ThenBy(n=>n.teamName))
            {
                Console.WriteLine(team.teamName);
                Console.WriteLine($"- {team.teamCreator}");
                
                foreach(string member in team.members.OrderBy(n=>n))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            
            Console.WriteLine("Teams to disband:");
            foreach (Team team in teamsToDisband.OrderBy(n=>n.teamName))
            {
                Console.WriteLine(team.teamName);
            }

            //output

            
        }
    }

    public class Team
    {
        public string teamCreator;
        public string teamName;
        public List<string> members;

        public Team(string creator, string name)
        {
            teamCreator = creator;
            teamName = name;
            members = new List<string> ();
            
        }
    }

    
}
