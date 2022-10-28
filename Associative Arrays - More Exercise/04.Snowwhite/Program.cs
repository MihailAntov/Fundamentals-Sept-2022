using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Dwarf> dwarves = new List<Dwarf>();
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] cmdArgs = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArgs[0];
                string hatColor = cmdArgs[1];
                int physics = int.Parse(cmdArgs[2]);

                if (!dwarves.Select(n => n.Name).ToArray().Contains(name))
                {
                    dwarves.Add(new Dwarf(name, hatColor, physics));
                }
                else
                {
                    if(!dwarves.Where(n=> n.Name == name).Select(n=>n.Hat).Contains(hatColor))
                    {
                        dwarves.Add(new Dwarf(name, hatColor, physics));
                    }
                    else
                    {
                        Dwarf existingDwarf = dwarves.FirstOrDefault(n => n.Name == name && n.Hat == hatColor);
                        if(existingDwarf.Physics < physics)
                        {
                            existingDwarf.Physics = physics;
                        }
                    }
                }
                
            }

            foreach (Dwarf dwarf in dwarves
                .OrderByDescending(n => n.Physics)
                .ThenByDescending(n =>
                dwarves.Where(m => m.Hat == n.Hat).Count())
                )
            {
                Console.WriteLine($"({dwarf.Hat}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }

    public class Dwarf
    {
        public Dwarf(string name, string hat, int physics)
        {
            Name = name;
            Hat = hat;
            Physics = physics;
        }

        public string Name { get; set; }
        public string Hat { get; set; }
        public int Physics { get; set; }
    }
}
