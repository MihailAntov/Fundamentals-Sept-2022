using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.MOBAChallenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, Player> players = new Dictionary<string, Player>();
            while ((input = Console.ReadLine())!= "Season end")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if(cmdArgs.Length  == 5)
                {
                    //player - position - skill : ignoring index 1 and 3 ("-")
                    string player = cmdArgs[0];
                    string position = cmdArgs[2];
                    int skill = int.Parse(cmdArgs[4]);

                    if(!players.ContainsKey(player))
                    {
                        players.Add(player, new Player(player, position, skill));
                    }
                    else
                    {
                        players[player].UpdateStats(position, skill);
                    }


                }
                else if (cmdArgs.Length == 3)
                {
                    //player vs player : ignoring index 1 ("vs")
                    string firstPlayer = cmdArgs[0];
                    string secondPlayer = cmdArgs[2];
                    if(!players.ContainsKey(firstPlayer) || !players.ContainsKey(secondPlayer))
                    {
                        continue;
                    }

                    string[] sharedPositions = players[firstPlayer].Positions.Keys.Intersect(players[secondPlayer].Positions.Keys).ToArray();
                    if(sharedPositions.Length > 0)
                    {
                        //duel happens
                        int firstPlayerTotal = players[firstPlayer].Positions.Values.Sum();
                        int secondPlayerTotal = players[secondPlayer].Positions.Values.Sum();

                        if(firstPlayerTotal > secondPlayerTotal)
                        {
                            players.Remove(secondPlayer);
                        }
                        else if (secondPlayerTotal > firstPlayerTotal)
                        {
                            players.Remove(firstPlayer);
                        }
                    }



                }
            }

            foreach(KeyValuePair<string, Player> player in players
                .OrderByDescending(n=> n.Value.Positions.Values.Sum())
                .ThenBy(n=> n.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Positions.Values.Sum()} skill");
                foreach(KeyValuePair<string, int> position in player.Value.Positions.OrderByDescending(n=> n.Value))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }

    public class Player
    {
        public Player(string name, string position, int skill)
        {
            Name = name;
            Positions = new Dictionary<string, int> { { position, skill } };
        }

        public string Name { get; set; }
        public Dictionary<string, int> Positions { get; set; }
        public void UpdateStats(string newPosition, int newSkill)
        {
            if(Positions.ContainsKey(newPosition))
            {
                if(Positions[newPosition] < newSkill)
                {
                    Positions[newPosition] = newSkill;
                }
            }
            else
            {
                Positions.Add(newPosition, newSkill);
            }
        }
    }
}
