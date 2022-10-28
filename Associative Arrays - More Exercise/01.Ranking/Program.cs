using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary <string, string> contests = new Dictionary<string, string>();
            Dictionary <string, Dictionary <string, int>> results = new Dictionary<string, Dictionary <string, int>>();
            while ((input = Console.ReadLine())!= "end of contests")
            {
                string[] cmdArgs = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = cmdArgs[0];
                string password = cmdArgs[1];
                contests.Add (contest, password);
            }

            while((input = Console.ReadLine())!= "end of submissions")
            {
                string[] submissionArgs = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = submissionArgs[0];
                string password = submissionArgs[1];
                string user = submissionArgs[2];
                int points = int.Parse(submissionArgs[3]);

                if(!contests.ContainsKey(contest))
                {
                    //invalid contest name
                    continue;
                }

                if (contests[contest] != password)
                {
                    //invalid password
                    continue;
                }


                //user checks:

                //user exists
                if(results.ContainsKey(user))
                {
                    //contest does not exist
                    if (!results[user].ContainsKey(contest))
                    {
                        //add contest
                        results[user].Add( contest, points );
                    }
                    //contest exists in student record already
                    else
                    {
                        //check if score is higher
                        if (results[user][contest] <points)
                        {
                            results[user][contest] = points;
                        }
                    }
                    
                }
                //user does not exist - > create user with new list of contests containing this contest
                else
                {
                    
                    results.Add(user, new Dictionary<string, int> { { contest, points } });
                }
            }
            
            GetBestStudent(results);
            Console.WriteLine("Ranking:");
            foreach(KeyValuePair<string, Dictionary<string, int>> student in results.OrderBy(n=>n.Key))
            {
                Console.WriteLine(student.Key);
                foreach(KeyValuePair<string, int> studentResults in student.Value.OrderByDescending(n=>n.Value))
                {
                    Console.WriteLine($"#  {studentResults.Key} -> {studentResults.Value}");
                }
            }

            
        }

        public static void GetBestStudent(Dictionary<string, Dictionary<string, int>> input)
        {
            int maxPoints = input.Select(n => n.Value.Values.Sum()).Max();
            string bestStudent = input.FirstOrDefault(n => n.Value.Values.Sum() == maxPoints).Key;

            Console.WriteLine($"Best candidate is {bestStudent} with total {maxPoints} points.");
            
        }
    }
}
