using System;

namespace _01.Hogwarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string spell = Console.ReadLine();

            string input;

            while((input = Console.ReadLine())!= "Abracadabra")
            {
                string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = inputArgs[0];

                switch(command)
                {
                    case "Abjuration":
                        spell = spell.ToUpper();
                        Console.WriteLine(spell);
                        break;
                    case "Necromancy":
                        spell = spell.ToLower();
                        Console.WriteLine(spell);
                        break;
                    case "Illusion":
                        int index = int.Parse(inputArgs[1]);
                        string letter = inputArgs[2];
                        if(index <0 || index >= spell.Length)
                        {
                            Console.WriteLine("The spell was too weak.");
                            continue;
                        }

                        spell = spell.Remove(index, 1);
                        spell = spell.Insert(index, letter);
                        Console.WriteLine("Done!");
                        break;
                    case "Divination":
                        string firstSubstring = inputArgs[1];
                        string secondSubstring = inputArgs[2];
                        if(!spell.Contains(firstSubstring))
                        {
                            continue;
                        }
                        spell = spell.Replace(firstSubstring, secondSubstring);
                        Console.WriteLine(spell);
                        break;
                    case "Alteration":
                        string substring = inputArgs[1];
                        
                        int indexOfSubstring = spell.IndexOf(substring);
                        if(indexOfSubstring == -1)
                        {
                            continue;
                        }
                        int lengthOfSubstring = substring.Length;
                        spell = spell.Remove(indexOfSubstring, lengthOfSubstring);
                        Console.WriteLine(spell);
                        break;
                    default:
                        Console.WriteLine("The spell did not work!");
                        break;
                }
            }
        }
    }
}
