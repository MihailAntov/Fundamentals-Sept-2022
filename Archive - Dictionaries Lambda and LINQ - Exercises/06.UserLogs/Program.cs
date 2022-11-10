using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.UserLogs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, Dictionary<string, List<string>>> users = new Dictionary<string, Dictionary<string, List<string>>>();
            while ((input = Console.ReadLine())!= "end")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string ip = ExtractInfo(cmdArgs[0]);
                string message = ExtractInfo(cmdArgs[1]);
                string user = ExtractInfo(cmdArgs[2]);

                if(!users.ContainsKey(user))
                {
                    users.Add(user,
                        new Dictionary<string, List<string>>
                        ());
                    
                }

                if (!users[user].ContainsKey(ip))
                {
                    users[user].Add(ip, new List<string>());
                }

                users[user][ip].Add(message);
                
            }

            foreach (KeyValuePair<string, Dictionary<string, List<string>>> user in users.OrderBy(n=>n.Key))
            {
                Console.WriteLine($"{user.Key}:");
                Console.Write(String.Join(
                    $", ",
                    user.Value.Select(n=>$"{n.Key} => {n.Value.Count}")));
                Console.Write(".\n");
            }
        }

        public static string ExtractInfo(string input)
        {
            string result = input.Substring(input.IndexOf("=")+1);
                
            return result;
        }
    }

     
    }

    

