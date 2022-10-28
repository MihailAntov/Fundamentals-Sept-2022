using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DragonArmy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Dragon> dragons = new List<Dragon>();  
            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = inputArgs[0];
                string name = inputArgs[1];
                int damage = int.Parse(inputArgs[2]== "null" ? "45" : inputArgs[2]);
                int health = int.Parse(inputArgs[3] == "null" ? "250" : inputArgs[3]);
                int armor = int.Parse(inputArgs[4] == "null" ? "10" : inputArgs[4]);
                Dragon existingDragon = dragons.FirstOrDefault(n=> n.Type == type && n.Name == name);
                if(existingDragon != null)
                {
                    existingDragon.Damage = damage;
                    existingDragon.Health = health;
                    existingDragon.Armor = armor;
                }
                else
                {
                    dragons.Add(new Dragon(type, name, damage, health, armor));
                }
                

            }

            List<string> dragonTypes = dragons.Select(n => n.Type).Distinct().ToList();

            foreach(string type in dragonTypes)
            {
                List<Dragon> dragonsOfThisType = dragons.Where(n => n.Type == type).ToList();
                double averageHealth = dragonsOfThisType.Select(n=>n.Health).Average();
                double averageArmor = dragonsOfThisType.Select(n => n.Armor).Average();
                double averageDamage = dragonsOfThisType.Select(n => n.Damage).Average();
                Console.WriteLine($"{type}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach(Dragon dragon in dragonsOfThisType.OrderBy(n=>n.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
    }

    public class Dragon
    {
        public Dragon(string type, string name, int damage, int health, int armor)
        {
            Type = type;
            Name = name;
            Damage = damage;
            Health = health;
            Armor = armor;
        }

        public string Type { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
    }
}
