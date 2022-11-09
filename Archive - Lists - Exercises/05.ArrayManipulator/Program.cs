using System;
using System.Linq;

namespace _05.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(n=>int.Parse(n))
                .ToArray();

            string input;

            while ((input = Console.ReadLine())!= "print")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                switch(command)
                {
                    case "add":
                        int addIndex = int.Parse(cmdArgs[1]);
                        int addElement = int.Parse(cmdArgs[2]);
                        ints = Add(ints, addIndex, addElement);
                        break;
                    case "addMany":
                        int addManyIndex = int.Parse(cmdArgs[1]);
                        int[] addManyElements = cmdArgs[2..]
                            .Select(n => int.Parse(n))
                            .ToArray();
                        ints = AddMany(ints, addManyIndex, addManyElements);
                        break;
                    case "contains":
                        int containsElement = int.Parse(cmdArgs[1]);
                        Console.WriteLine(Contains(ints, containsElement));
                        break;
                    case "remove":
                        int removeIndex = int.Parse(cmdArgs[1]);
                        ints = Remove(ints, removeIndex);
                        break;
                    case "shift":
                        int shiftPositions = int.Parse(cmdArgs[1]);
                        ints = Shift(ints, shiftPositions);
                        break;
                    case "sumPairs":
                        ints = SumPairs(ints);
                        break;
                }
            }

            Console.WriteLine($"[{String.Join(", ",ints)}]");
        }

        public static int[] Add(int[] array, int index, int element)
        {
            int[] result = new int[array.Length+1];
            for(int i = 0; i < index; i++)
            {
                result[i] = array[i];
            }
            result[index] = element;
            for (int i = index+1; i < result.Length; i++)
            {
                result[i] = array[i - 1];
            }
            return result;
        }

        public static int[] AddMany(int[] array, int index, int[] elements)
        {
            int[] result = new int[array.Length + elements.Length];
            for (int i = 0; i < index; i ++)
            {
                result[i] = array[i];
            }

            for (int i = 0; i < elements.Length; i ++)
            {
                result[index + i] = elements[i];
            }

            for (int i = index + elements.Length; i < result.Length; i++)
            {
                result[i]= array[i-elements.Length];
            }
            return result;
        }

        public static int Contains(int[] array, int element)
        {
            int result = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == element)
                {
                    result = i;
                    break;
                }
            }
            return result;
            
        }

        public static int[] Remove(int[] array, int index)
        {
            int[] result = new int[array.Length - 1];
            for (int i = 0; i < index; i++)
            {
                result[i] = array[i];
            }
            for (int i = index; i < result.Length; i++)
            {
                result[i] = array[i + 1];
            }
            return result;
        }
        public static int[] Shift(int[] array, int positions)
        {
            int[] result = new int[array.Length];
            
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = array[(result.Length + positions + i)%result.Length];
            }
            return result;
        }

        public static int[] SumPairs(int[] array)
        {
            if(array.Length % 2 == 0)
            {
                int[] result = new int[array.Length / 2];
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = array[2 * i] + array[2 * i + 1];
                }
                return result;
            }
            else
            {
                int[] result = new int[array.Length / 2 + 1];
                for (int i = 0; i < result.Length -1; i++)
                {
                    result[i] = array[2 * i] + array[2 * i + 1];
                }
                result[result.Length - 1] = array[array.Length - 1];
                return result;
            }
        }
    }
}
