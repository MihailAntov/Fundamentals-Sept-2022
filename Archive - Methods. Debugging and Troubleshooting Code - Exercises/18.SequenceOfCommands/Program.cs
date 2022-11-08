using System;
using System.Linq;

public class SequenceOfCommands_broken
{


    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());
        char ArgumentsDelimiter = ' ';
        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToArray();

        string command;

        while ((command = Console.ReadLine())!= "stop")
        {
            string[] cmdArgs = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int[] args = new int[2];
            string action = cmdArgs[0];
            if (action == "add" || action == "subtract" || action == "multiply")
            {
                args[0] = int.Parse(cmdArgs[1]);
                args[1] = int.Parse(cmdArgs[2]);
  
            }
            

            PerformAction(array, action, args);
            //PerformAction(array, command, args);

            PrintArray(array);
            //Console.WriteLine('\n');

            
        }
    }

    static void PerformAction(long[] arr, string action, int[] args)
    {
        
        int pos = args[0];
        int value = args[1];

        switch (action)
        {
            case "multiply":
                arr[pos-1] *= value;
                break;
            case "add":
                arr[pos-1] += value;
                break;
            case "subtract":
                arr[pos-1] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(arr);
                break;
            case "rshift":
                ArrayShiftRight(arr);
                break;
        }
    }

    private static void ArrayShiftRight(long[] array)
    {
        long buffer = array[array.Length-1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = buffer;
    }

    private static void ArrayShiftLeft(long[] array)
    {
        long buffer = array[0];
        for (int i = 0; i < array.Length-1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length-1] = buffer;
    }

    private static void PrintArray(long[] array)
    { 
        Console.WriteLine(String.Join(" ",array)); 
    }
}
