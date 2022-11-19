//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace _01.Ranking
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string input;
//            Dictionary <string, string> contests = new Dictionary<string, string>();
//            Dictionary <string, Dictionary <string, int>> results = new Dictionary<string, Dictionary <string, int>>();
//            while ((input = Console.ReadLine())!= "end of contests")
//            {
//                string[] cmdArgs = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
//                string contest = cmdArgs[0];
//                string password = cmdArgs[1];
//                contests.Add (contest, password);
//            }

//            while((input = Console.ReadLine())!= "end of submissions")
//            {
//                string[] submissionArgs = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
//                string contest = submissionArgs[0];
//                string password = submissionArgs[1];
//                string user = submissionArgs[2];
//                int points = int.Parse(submissionArgs[3]);

//                if(!contests.ContainsKey(contest))
//                {
//                    //invalid contest name
//                    continue;
//                }

//                if (contests[contest] != password)
//                {
//                    //invalid password
//                    continue;
//                }


//                //user checks:

//                //user exists
//                if(results.ContainsKey(user))
//                {
//                    //contest does not exist
//                    if (!results[user].ContainsKey(contest))
//                    {
//                        //add contest
//                        results[user].Add( contest, points );
//                    }
//                    //contest exists in student record already
//                    else
//                    {
//                        //check if score is higher
//                        if (results[user][contest] <points)
//                        {
//                            results[user][contest] = points;
//                        }
//                    }

//                }
//                //user does not exist - > create user with new list of contests containing this contest
//                else
//                {

//                    results.Add(user, new Dictionary<string, int> { { contest, points } });
//                }
//            }

//            GetBestStudent(results);
//            Console.WriteLine("Ranking:");
//            foreach(KeyValuePair<string, Dictionary<string, int>> student in results.OrderBy(n=>n.Key))
//            {
//                Console.WriteLine(student.Key);
//                foreach(KeyValuePair<string, int> studentResults in student.Value.OrderByDescending(n=>n.Value))
//                {
//                    Console.WriteLine($"#  {studentResults.Key} -> {studentResults.Value}");
//                }
//            }


//        }

//        public static void GetBestStudent(Dictionary<string, Dictionary<string, int>> input)
//        {
//            int maxPoints = input.Select(n => n.Value.Values.Sum()).Max();
//            string bestStudent = input.FirstOrDefault(n => n.Value.Values.Sum() == maxPoints).Key;

//            Console.WriteLine($"Best candidate is {bestStudent} with total {maxPoints} points.");

//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            string contestInput = Console.ReadLine();

            while (contestInput != "end of contests")
            {
                string[] currentInput = contestInput.Split(":");

                string contestName = currentInput[0];
                string contestPassword = currentInput[1];

                contests.Add(contestName, contestPassword);

                contestInput = Console.ReadLine();
            }

            string personInput = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();

            while (personInput != "end of submissions")
            {
                string[] currentPerson = personInput.Split("=>");
                string contestName = currentPerson[0];
                string contestPassword = currentPerson[1];
                string personName = currentPerson[2];
                int points = int.Parse(currentPerson[3]);
                //check if the contest is valid
                if (!contests.ContainsKey(contestName))
                {
                    personInput = Console.ReadLine();
                    continue;
                }
                //check password for the given contest
                if (contests[contestName] != contestPassword)
                {
                    personInput = Console.ReadLine();
                    continue;
                }
                //if person exists
                if (data.ContainsKey(personName))
                {
                    //if person exists in the same contest and new points are bigger than previous
                    if (data[personName].ContainsKey(contestName) && data[personName][contestName] < points)
                    {
                        data[personName][contestName] = points;
                    }
                    else if (!data[personName].ContainsKey(contestName))
                    {
                        data[personName].Add(contestName, points);
                    }
                }
                else
                //if not, add it
                {
                    var currentRecord = new Dictionary<string, int>();
                    data.Add(personName, currentRecord);
                    currentRecord.Add(contestName, points);
                }

                personInput = Console.ReadLine();
            }

            Dictionary<string, int> aggregation = new Dictionary<string, int>();

            foreach (var item in data)
            {
                aggregation.Add(item.Key, 0);

                foreach (var item2 in item.Value)
                {
                    aggregation[item.Key] += item2.Value;
                }
            }
            double totalPoints = aggregation.Values.Max();

            //string bestCandidate = aggregation.Where(n => n.Value == aggregation.Values.Max()).Select(n=>n.Key).First();
            string bestCandidate = aggregation.Take(1).Select(x => x.Key).First();

            Console.WriteLine($"Best candidate is {bestCandidate} with total {totalPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var item in data.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var item2 in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item2.Key} -> {item2.Value}");
                }
            }
        }
    }
}