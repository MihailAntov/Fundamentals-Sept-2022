using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;

            while ((input = Console.ReadLine())!= "3:1")
            {
                string[] cmdArgs = input.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = cmdArgs[0];

                switch (command)
                {
                    case "merge":
                        int startIndex = int.Parse(cmdArgs[1]);
                        int endIndex = int.Parse(cmdArgs[2]);

                        if (startIndex < 0)
                        { 
                            startIndex = 0; 
                        }
                        if (endIndex < 0)
                        {
                            endIndex = 0;
                        }



                        if (endIndex >= strings.Count)
                        {
                            endIndex = strings.Count - 1;
                        }
                        if (startIndex >= strings.Count)
                        {
                            startIndex = strings.Count - 1;
                        }


                        string newValue = string.Empty;
                        for (int i = startIndex; i <= endIndex; i++ )
                        {
                            newValue += strings[i];
                        } 
                        strings.RemoveRange(startIndex, endIndex + 1 - startIndex);
                        strings.Insert(startIndex, newValue);

                        break;
                    case "divide":
                        int index = int.Parse(cmdArgs[1]);
                        if (index < 0 || index > strings.Count-1)
                        {
                            continue;
                        }
                        int partitions = int.Parse(cmdArgs[2]);
                        if (partitions <= 0)
                        {
                            continue;
                        }
                        string stringToBeDivided = strings[index];

                        List<string> result = new List<string>();
                        
                        for (int i = 0; i < partitions; i ++)
                        {
                            result.Add("");
                        }

                        int equalAmountsTotalSum = partitions * (stringToBeDivided.Length / partitions);
                        int leftOver = stringToBeDivided.Length - equalAmountsTotalSum;
                        int equalAmountsPerDivision = equalAmountsTotalSum / partitions;
                        
                        for (int i = 0; i < partitions; i++)
                        {
                            result[i] = stringToBeDivided.Substring(i * equalAmountsPerDivision, equalAmountsPerDivision);
                        }

                        result[result.Count - 1] += stringToBeDivided.Substring(equalAmountsTotalSum, leftOver);
                        strings.RemoveAt(index);
                        for (int i = 0; i < result.Count; i++)
                        {
                            strings.Insert(index + i, result[i]);
                        }

                        break;
                }
            }

            Console.WriteLine(String.Join(" ", strings));


        }
    }
}
