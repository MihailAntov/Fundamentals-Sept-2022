using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<String, Contest> contests = new Dictionary<String, Contest>();
            
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] cmdArgs = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string user = cmdArgs[0];
                string contest = cmdArgs[1];
                int points = int.Parse(cmdArgs[2]);

                if(!contests.ContainsKey(contest))
                {
                    //if no such contests exists, create it
                    contests.Add(contest, new Contest(contest));
                    
                }

                if(!students.ContainsKey(user))
                {
                    students.Add(user, 0);
                }

                if (contests[contest].Results.ContainsKey(user))
                {
                    //check if user already participated in this contest
                    //if so, update score if higher

                    if(contests[contest].Results[user] < points)
                    {
                        students[user] -= contests[contest].Results[user];
                        contests[contest].Results[user] = points;
                        students[user] += points;
                        
                    }

                }
                else
                {
                    //add user's entry into contest
                    contests[contest].Results.Add(user, points);
                    students[user] += points;
                }
            }

            foreach(KeyValuePair<string, Contest> contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Results.Count} participants");
                int standing = 0;
                foreach(KeyValuePair<string, int> result in contest.Value.Results.OrderByDescending(n=>n.Value).ThenBy(n=>n.Key))
                {
                    standing++;
                    Console.WriteLine($"{standing}. {result.Key} <::> {result.Value}");
                }
            }

            Console.WriteLine("Individual standings:");
            int individualStanding = 0;
            foreach(KeyValuePair<string, int>student in students.OrderByDescending(n=> n.Value).ThenBy(n=>n.Key))
            {
                individualStanding++;
                Console.WriteLine($"{individualStanding}. {student.Key} -> {student.Value}");
            }
        }
    }

    public class Contest
    {
        public Contest(string name)
        {
            Name = name;
            Results = new Dictionary<string, int>();
        }

        public string Name { get; set; }
        public Dictionary<string, int> Results { get; set; }
    }


}
