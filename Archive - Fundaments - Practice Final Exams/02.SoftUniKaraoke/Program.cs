using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.SoftUniKaraoke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> performerInput = Console.ReadLine()
                .Split(',')
                .Select(x => x.Trim())
                .ToList();
            Dictionary<string, Performer> performers = new Dictionary<string, Performer>();
            foreach(string performer in performerInput)
            {
                if(!performers.ContainsKey(performer))
                {
                    performers.Add(performer,new Performer());
                }
                
            }

            List<string> songInput = Console.ReadLine()
                .Split(',')
                .Select(n=>n.Trim())
                .ToList();

            string input;

            while((input = Console.ReadLine())!= "dawn")
            {
                string[] inputArgs = input.Split(',').Select(n=>n.Trim()).ToArray();
                string performer = inputArgs[0];
                string song = inputArgs[1];
                string award = inputArgs[2];

                if(!performers.ContainsKey(performer))
                {
                    continue;
                }

                if(!songInput.Contains(song))
                {
                    continue;
                }

                performers[performer].Awards.Add(award);
            }

            if(performers.Select(n=>n.Value.Awards.Count()).Sum() == 0)
            {
                Console.WriteLine("No awards");
                return;
            }


            foreach(KeyValuePair<string, Performer> performer in performers
                .Where(n=>n.Value.Awards.Count > 0)
                .OrderByDescending(n=>n.Value.Awards
                .Distinct()
                .Count())
                .ThenBy(n=>n.Key))
            {
                Console.WriteLine($"{performer.Key}: {performer.Value.Awards.Distinct().Count()} awards");
                
                
                foreach(string award in performer.Value.Awards.Distinct().OrderBy(n=>n))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }

    public class Performer
    {
        List<string> awards;
        public Performer()
        {
            
            awards = new List<string>();
        }
        public string Name { get; set; }
        public List<string> Awards { get { return awards; } }
    }
}
