using System;

namespace _02.MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;

            string[] rooms = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] roomContents = rooms[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = roomContents[0];

                switch (command)
                {
                    case "potion":
                        int healing = int.Parse(roomContents[1]);
                        if (healing + health < 100)
                        {
                            health += healing;
                            Console.WriteLine($"You healed for {healing} hp.");
                        }
                        else
                        {
                            Console.WriteLine($"You healed for {100-health} hp.");
                            health = 100;
                        }
                        Console.WriteLine($"Current health: {health} hp.");
                        break;
                    case "chest":
                        int loot = int.Parse(roomContents[1]);
                        bitcoins += loot;
                        Console.WriteLine($"You found {loot} bitcoins.");
                        break;
                    default:
                        int monsterAttack = int.Parse(roomContents[1]);
                        if (health > monsterAttack)
                        {
                            health -= monsterAttack;
                            Console.WriteLine($"You slayed {command}.");
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {command}.");
                            Console.WriteLine($"Best room: {i+1}");
                            return;
                        }
                        break;
                }
            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
