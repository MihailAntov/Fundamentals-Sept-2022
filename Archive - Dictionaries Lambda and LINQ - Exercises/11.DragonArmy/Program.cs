using System;
using System.Collections.Generic;
using System.Linq;
namespace _11.DragonArmy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<Dragon>> types = new Dictionary<string, List<Dragon>>();
            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string type = inputArgs[0];
                string name = inputArgs[1];
                int damage = 45;
                int health = 250;
                int armor = 10;
                if (inputArgs[2] != "null")
                {
                    damage = int.Parse(inputArgs[2]);   
                }

                if (inputArgs[3] != "null")
                {
                    health = int.Parse(inputArgs[3]);
                }

                if (inputArgs[4] != "null")
                {
                    armor = int.Parse(inputArgs[4]);
                }

                if(!types.ContainsKey(type))
                {
                    types.Add(type, new List<Dragon>());
                }

                if (types[type].Select(n=>n.Name).Contains(name))
                {
                    Dragon dragon = types[type].Where(n => n.Name == name).FirstOrDefault();
                    dragon.Armor = armor;
                    dragon.Health = health;
                    dragon.Damage = damage;
                }
                else
                {
                    types[type].Add(new Dragon(name, damage, health, armor));
                }
                
                
            }

            foreach(KeyValuePair<String, List<Dragon>> type in types)
            {
                double avgHealth = type.Value.Select(n => n.Health).Average();
                double avgArmor = type.Value.Select(n => n.Armor).Average();
                double avgDamage = type.Value.Select(n => n.Damage).Average();
                Console.WriteLine($"{type.Key}::({avgDamage:f2}/{avgHealth:f2}/{avgArmor:f2})");
                foreach(Dragon dragon in type.Value.OrderBy(n=>n.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
    }

    public class Dragon
    {
        public Dragon(string name, int damage, int health, int armor)
        {
            Name = name;
            Damage = damage;
            Health = health;
            Armor = armor;
        }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
    }
}
