using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDontGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            int sum = 0;

            while (numbers.Count > 0)
            {
                int nextIndex = int.Parse(Console.ReadLine());

                int valueOfThisCatch;

                if (nextIndex < 0)
                {
                    valueOfThisCatch = numbers[0];
                    
                    numbers[0] = numbers[numbers.Count - 1];
                }
                else if (nextIndex >= numbers.Count)
                {
                    valueOfThisCatch = numbers[numbers.Count-1];
                    numbers[numbers.Count-1] = numbers[0];
                }
                else
                {
                    valueOfThisCatch = numbers[nextIndex];
                    numbers.RemoveAt(nextIndex); 
                }

                sum += valueOfThisCatch;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= valueOfThisCatch)
                    {
                        numbers[i] += valueOfThisCatch;
                    }
                    else if (numbers[i] > valueOfThisCatch)
                    {
                        numbers[i] -= valueOfThisCatch;
                    }

                    
                }

                
            }
            Console.WriteLine(sum);
        }
    }
}
