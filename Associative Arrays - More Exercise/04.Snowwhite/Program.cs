//using System;
//using System.Linq;
//using System.Collections.Generic;

//namespace _04.Snowwhite
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string input;
//            List<Dwarf> dwarves = new List<Dwarf>();
//            while ((input = Console.ReadLine()) != "Once upon a time")
//            {
//                string[] cmdArgs = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);
//                string name = cmdArgs[0];
//                string hatColor = cmdArgs[1];
//                int physics = int.Parse(cmdArgs[2]);

//                if (!dwarves.Select(n => n.Name).ToArray().Contains(name))
//                {
//                    dwarves.Add(new Dwarf(name, hatColor, physics));
//                }
//                else
//                {
//                    if(!dwarves.Where(n=> n.Name == name).Select(n=>n.Hat).Contains(hatColor))
//                    {
//                        dwarves.Add(new Dwarf(name, hatColor, physics));
//                    }
//                    else
//                    {
//                        Dwarf existingDwarf = dwarves.FirstOrDefault(n => n.Name == name && n.Hat == hatColor);
//                        if(existingDwarf.Physics < physics)
//                        {
//                            existingDwarf.Physics = physics;
//                        }
//                    }
//                }

//            }

//            foreach (Dwarf dwarf in dwarves
//                .OrderByDescending(n => n.Physics)
//                .ThenByDescending(n =>
//                dwarves.Where(m => m.Hat == n.Hat).Count())
//                )
//            {
//                Console.WriteLine($"({dwarf.Hat}) {dwarf.Name} <-> {dwarf.Physics}");
//            }
//        }
//    }

//    public class Dwarf
//    {
//        public Dwarf(string name, string hat, int physics)
//        {
//            Name = name;
//            Hat = hat;
//            Physics = physics;
//        }

//        public string Name { get; set; }
//        public string Hat { get; set; }
//        public int Physics { get; set; }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;

namespace snowWhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dwarf> dwarfs = new Dictionary<string, Dwarf>();
            string input;
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] inputArg = input
                    .Split(" <:> ")
                    .ToArray();
                string name = inputArg[0];
                string hat = inputArg[1];
                int physics = int.Parse(inputArg[2]);
                string key = name + hat;
                Dwarf newDwarf = new Dwarf(name, hat, physics);
                if (!dwarfs.ContainsKey(key))
                {
                    dwarfs.Add(key, newDwarf);
                }
                else
                {
                    dwarfs[key].Physics = Math.Max(physics, dwarfs[key].Physics);
                }

            }


            foreach (var dw in dwarfs.OrderByDescending(x => x.Value.Physics).ThenByDescending(x => (x.Value.Hat).Count()))
            {
                Console.WriteLine($"({dw.Value.Hat}) {dw.Value.Name} <-> {dw.Value.Physics}");
                Console.WriteLine(dw.Value.Hat.Count());
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

