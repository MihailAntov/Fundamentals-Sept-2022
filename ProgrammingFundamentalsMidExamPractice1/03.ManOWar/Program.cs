using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ManOWar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pirateShip = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            int[] warShip = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            int maxHealth = int.Parse(Console.ReadLine());

            string input;

            while ((input = Console.ReadLine()) != "Retire")
            {
                string[] cmdArgs = input.Split(" ");
                string command = cmdArgs[0];

                switch (command)
                {
                    case "Fire":
                        int indexOfAttack = int.Parse(cmdArgs[1]);
                        int damage = int.Parse(cmdArgs[2]);
                        if (indexOfAttack < 0 || indexOfAttack >= warShip.Length)
                        {
                            continue;
                        }
                        warShip[indexOfAttack] -= damage;
                        if (warShip[indexOfAttack] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                        

                        break;
                    case "Defend":
                        int startIndexOfDefence = int.Parse(cmdArgs[1]);
                        int endIndexOfDefence = int.Parse(cmdArgs[2]);
                        int damageOnDefence = int.Parse(cmdArgs[3]);

                        if (startIndexOfDefence <0 || endIndexOfDefence >= pirateShip.Length)
                        {
                            continue;
                        }
                        for (int i = startIndexOfDefence; i <= endIndexOfDefence; i++)
                        {
                            pirateShip[i] -= damageOnDefence;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                        break;
                    case "Repair":
                        int repairIndex = int.Parse(cmdArgs[1]);
                        int health = int.Parse(cmdArgs[2]);

                        if(repairIndex < 0 || repairIndex >= pirateShip.Length)
                        {
                            continue;
                        }

                        if (pirateShip[repairIndex] + health <= maxHealth)
                        {
                            pirateShip[repairIndex] += health;
                        }
                        else
                        {
                            pirateShip[repairIndex] = maxHealth;
                        }

                        break;
                    case "Status":
                        int[] damagedSections = pirateShip.Where(n=>n<0.2 * maxHealth).ToArray();
                        Console.WriteLine($"{damagedSections.Length} sections need repair.");
                        break;
                }
            }

            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");
        }
    }
}
