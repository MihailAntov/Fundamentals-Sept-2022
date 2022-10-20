using System;
using System.Collections.Generic;
using System.Linq;



class Program
{
    static void Main()
    {
        List<int> num = Console.ReadLine().Split().Select(int.Parse).ToList();

        while (true)
        {
            string line = Console.ReadLine();
            if (line == "end")
            {
                break;
            }

            string[] tokens = line.Split();
            string action = tokens[0];

            switch (action)
            {
                case "Delete":
                    int numberToDelete = int.Parse(tokens[1]);
                    if (num.Contains(numberToDelete))
                    {
                        num.Remove(numberToDelete);
                    }

                    break;
                case "Insert":
                    int numberToInsert = int.Parse(tokens[1]);
                    int indexToInsertAt = int.Parse(tokens[2]);
                    num.Insert(indexToInsertAt, numberToInsert);
                    break;
            }

        }
        Console.WriteLine(string.Join(" ", num));

    }
}