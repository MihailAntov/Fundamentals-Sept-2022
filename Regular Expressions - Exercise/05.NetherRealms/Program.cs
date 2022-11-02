using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _05.NetherRealms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string nameFilter = @"[^\,\s]+";
            string characterFilter = @"[^\d\+\-\/\.\*]";
            string numberFilter = @"((|-)\d+\.\d+|(|-)\d+)";
            string mathFilter = @"\/|\*";
            List<Demon> demons = new List<Demon>();
            
            MatchCollection names = Regex.Matches(input, nameFilter);

            foreach (Match m in names)
            {
                string name = m.Value.ToString();
                
                char[] characters = Regex.Matches(name, characterFilter).Select(n =>char.Parse(n.Value)).ToArray();
                double[] numbers = Regex.Matches(name, numberFilter).Select(n => double.Parse(n.Value)).ToArray();
                char[] mathOperations = Regex.Matches(name, mathFilter).Select(n => char.Parse(n.Value)).ToArray();

                int health = characters.Select(n => (int)n).Sum();     
                double baseDamage = 1.0 * numbers.Sum();

                for (int i = 0; i < mathOperations.Length; i++)
                {
                    if (mathOperations[i] == '*')
                    {
                        baseDamage *= 2;
                    }
                    else
                    {
                        baseDamage /= 2;
                    }
                }

                demons.Add(new Demon(name, baseDamage, health));

            }

            foreach(Demon demon in demons.OrderBy(n=>n.Name))
            {
                Console.WriteLine(demon);
            }
        }
    }

    public class Demon
    {
        public Demon(string name, double damage, int health)
        {
            Name = name;
            Damage = damage;
            Health = health;
        }

        public string Name { get; set; }
        public double Damage { get; set; }
        public int Health { get; set; }
        public override string  ToString()
        {
            return $"{Name} - {Health} health, {Damage:f2} damage";
        }
    }
}
