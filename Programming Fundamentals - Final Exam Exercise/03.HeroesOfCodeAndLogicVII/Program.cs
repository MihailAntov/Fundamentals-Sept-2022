using System;
using System.Collections.Generic;
namespace _03.HeroesOfCodeAndLogicVII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();
            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string name = inputArgs[0];
                int hp = int.Parse(inputArgs[1]);
                int mp = int.Parse(inputArgs[2]);
                Hero hero = new Hero(name, hp, mp);
                heroes.Add(name, hero);
            }

            string input;

            while((input = Console.ReadLine())!= "End")
            {
                string[] inputArgs = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string command = inputArgs[0];
                Hero hero = heroes[inputArgs[1]];

                if(command == "CastSpell")
                {
                    int manaCost = int.Parse(inputArgs[2]);
                    string spell = inputArgs[3];

                    if(hero.MP >= manaCost)
                    {
                        hero.MP -= manaCost;
                        Console.WriteLine($"{hero.Name} has successfully cast {spell} and now has {hero.MP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{hero.Name} does not have enough MP to cast {spell}!");
                    }
                }
                else if (command == "TakeDamage")
                {
                    int damage = int.Parse(inputArgs[2]);
                    string attacker = inputArgs[3];
                    hero.HP-= damage;
                    if(hero.HP <= 0)
                    {
                        Console.WriteLine($"{hero.Name} has been killed by {attacker}!");
                        heroes.Remove(hero.Name);
                        continue;
                    }

                    Console.WriteLine($"{hero.Name} was hit for {damage} HP by {attacker} and now has {hero.HP} HP left!");
                }
                else if (command == "Recharge")
                {
                    int amount = int.Parse(inputArgs[2]);
                    int amountRecovered = Math.Min(amount, 200 - hero.MP);
                    hero.MP += amountRecovered;
                    Console.WriteLine($"{hero.Name} recharged for {amountRecovered} MP!");
                }
                else if (command == "Heal")
                {
                    int amount = int.Parse(inputArgs[2]);
                    int amountRecovered = Math.Min(amount, 100 - hero.HP);
                    hero.HP += amountRecovered;
                    Console.WriteLine($"{hero.Name} healed for {amountRecovered} HP!");
                }
            }

            foreach(KeyValuePair<string, Hero> hero in heroes)
            {
                Console.WriteLine($"{hero.Key}\n  HP: {hero.Value.HP}\n  MP: {hero.Value.MP}");
            }
        }
    }

    public class Hero
    {
        public Hero(string name, int hp, int mp)
        {
            Name = name;
            HP = hp > 100 ? 100 : hp;
            MP = mp > 200 ? 200 : mp;
        }

        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
    }
}
