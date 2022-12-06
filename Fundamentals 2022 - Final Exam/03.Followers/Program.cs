using System;
using System.Collections.Generic;
namespace _03.Followers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            string input;
            Dictionary<string, Follower> followers = new Dictionary<string, Follower>();
            while((input = Console.ReadLine())!= "Log out")
            {
                string[] inputArgs = input.Split(": ",StringSplitOptions.RemoveEmptyEntries);
                string command = inputArgs[0];
                string userName = inputArgs[1];
                if (command == "New follower")
                {
                    
                    if(!followers.ContainsKey(userName))
                    {
                        followers.Add(userName, new Follower(userName));
                    }
                }
                else if (command == "Like")
                {
                    if (!followers.ContainsKey(userName))
                    {
                        followers.Add(userName, new Follower(userName));
                    }
                    int likes = int.Parse(inputArgs[2]);
                    followers[userName].Likes += likes;
                }
                else if (command == "Comment")
                {
                    if (!followers.ContainsKey(userName))
                    {
                        followers.Add(userName, new Follower(userName));
                    }
                    followers[userName].Comments++;
                }
                else if (command == "Blocked")
                {
                    if(!followers.ContainsKey(userName))
                    {
                        Console.WriteLine($"{userName} doesn't exist.");
                        continue;
                    }

                    followers.Remove(userName);
                }
            }

            Console.WriteLine($"{followers.Count} followers");
            Console.WriteLine(String.Join(Environment.NewLine,followers.Values));


        }
    }

    public class Follower
    {
        public Follower(string name)
        {
            Name = name;
            Likes = 0;
            Comments = 0;
        }
        public string Name { get; set; }
        public int Likes { get; set; }
        public int Comments { get; set; }
        public override string ToString()
        {
            return $"{Name}: {Likes + Comments}";
        }
    }
}
