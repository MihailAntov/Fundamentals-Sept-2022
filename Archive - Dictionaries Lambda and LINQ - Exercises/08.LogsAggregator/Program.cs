using System;
using System.Collections.Generic;
using System.Linq;
namespace _08.LogsAggregator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string ip = inputArgs[0];
                string name = inputArgs[1];
                int duration = int.Parse(inputArgs[2]);

                if(!users.ContainsKey(name))
                {
                    users.Add(name, new Dictionary<string, int>());
                }

                if (!users[name].ContainsKey(ip))
                {
                    users[name].Add(ip, 0);
                }

                users[name][ip] += duration;
            }

            foreach(KeyValuePair<string, Dictionary<string, int>> user in users.OrderBy(n=>n.Key))
            {
                int totalDuration = user.Value.Select(n => n.Value).Sum();

                Console.WriteLine($"{user.Key}: {totalDuration} [{string.Join(", ",user.Value.Select(n=>n.Key).OrderBy(n=>n))}]");
            }
        }
    }
}
