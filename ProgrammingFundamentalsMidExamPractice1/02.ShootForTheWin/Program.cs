using System;
using System.Linq;

namespace _02.ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            string input;
            int shotTargets = 0;

            while ((input = Console.ReadLine())!= "End")
            {
                int index = int.Parse(input);

                if(index < 0 || index>= targets.Length)
                {
                    continue;
                }
                int lastValueOfTarget = targets[index];
                targets[index] = -1;
                shotTargets++;

                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[i] == -1)
                    {
                        continue;
                    }

                    if (targets[i] > lastValueOfTarget)
                    {
                        targets[i] -= lastValueOfTarget;
                    }
                    else if (targets[i] <= lastValueOfTarget)
                    {
                        targets[i] += lastValueOfTarget;
                    }

                }
            }

            Console.WriteLine($"Shot targets: {shotTargets} -> {String.Join(" ", targets)}");


        }
    }
}
