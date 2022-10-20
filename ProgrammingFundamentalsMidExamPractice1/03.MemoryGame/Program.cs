using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;
            int movesCounter = 0;

            while ((input = Console.ReadLine())!= "end")
            {
                movesCounter++;
                int[] indices = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => int.Parse(n))
                    .ToArray();
                int lower = Math.Min(indices[0], indices[1]);
                int higher = Math.Max(indices[0], indices[1]);
                if (lower < 0 || higher >= elements.Count || indices[0] == indices[1])
                {
                    int middle = elements.Count() / 2;
                    elements.Insert(middle, $"-{movesCounter}a");
                    elements.Insert(middle, $"-{movesCounter}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    
                }
                else if (elements[lower] == elements[higher])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[lower]}!");
                    elements.RemoveAt(higher);
                    elements.RemoveAt(lower);
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                if(elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {movesCounter} turns!");
                    break;
                }
            }

            if(elements.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
            }

            Console.WriteLine(String.Join(" ",elements));
        }
    }
}
