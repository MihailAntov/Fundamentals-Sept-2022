using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPlayers = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> players = new Dictionary<string, List<int>>();
            for (int i = 0; i < totalPlayers; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string heroName = cmdArgs[0];
                int hp = int.Parse(cmdArgs[1]);
                int mp = int.Parse(cmdArgs[2]);

                players.Add(heroName, new List<int>());
                players[heroName].Add(hp);
                players[heroName].Add(mp);

            }
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];

                if (action == "CastSpell")
                {
                    string heroName = cmdArgs[1];
                    int mpNeeded = int.Parse(cmdArgs[2]);
                    string spellName = cmdArgs[3];
                    int currMp = players[heroName][1];

                    if (mpNeeded <= currMp)
                    {
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {currMp - mpNeeded} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                    players[heroName][1] = currMp - mpNeeded;
                }
                else if (action == "TakeDamage")
                {
                    string heroName = cmdArgs[1];
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];
                    int currHp = players[heroName][0];
                    players[heroName][0] -= damage;
                    if (currHp - damage > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {currHp - damage} HP left!");

                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        players.Remove(heroName);
                    }
                }
                else if (action == "Recharge")
                {
                    string heroName = cmdArgs[1];
                    int amount = int.Parse(cmdArgs[2]);

                    int currMp = players[heroName][1];
                    currMp += amount;
                    if (currMp > 200)
                    {
                        int over = currMp - 200;
                        amount -= over;

                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                        currMp = 200;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    }
                    players[heroName][1] = currMp;
                }
                else if (action == "Heal")
                {
                    string heroName = cmdArgs[1];
                    int amount = int.Parse(cmdArgs[2]);

                    int currHp = players[heroName][0];
                    currHp += amount;
                    if (currHp > 100)
                    {
                        int over = currHp - 100;
                        amount -= over;

                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                        currHp = 100;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                    }
                    players[heroName][0] = currHp;
                }
            }
            foreach (var kvp in players)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine($"  HP: {kvp.Value[0]}");
                Console.WriteLine($"  MP: {kvp.Value[1]}");
            }
        }
    }
}