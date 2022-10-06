using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input;

            while ((input = Console.ReadLine())!= "end")
            {
                string[] command = input.Split(" ");

                switch (command[0])
                {
                    case "exchange":
                        arr = Exchange(int.Parse(command[1]), arr);
                        break;
                    case "max":
                        Max(command[1], arr);
                        break;
                    case "min":
                        Min(command[1], arr);
                        break;
                    case "first":
                        First(int.Parse(command[1]), command[2], arr);
                        break;
                    case "last":
                        Last(int.Parse(command[1]), command[2], arr);
                        break;
                }

                
            }
            string result = "[" + string.Join(", ", arr) + "]";
            Console.WriteLine(result);
        }
        static int[] Exchange(int index, int[] arr)
        {
            if (index < 0 || index >= arr.Length)
            {
                Console.WriteLine("Invalid index");
                return arr;
            }
            else
            {
                int[] firstSubArray = arr[0..(index+1)];
                int[] secondSubArray = arr[(index+1)..(arr.Length)];
                arr = secondSubArray.Concat(firstSubArray).ToArray();
                //string result = "[" + String.Join(", ", arr) + "]";
                //Console.WriteLine(result);
                return arr;
            }
        }

        static void Max(string parameter, int[] arr)
        {
            int maxIndex = -1;
            int maxValue = int.MinValue;

            if (parameter == "even")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] >= maxValue && arr[i] % 2 == 0)
                    {
                        maxValue = arr[i];
                        maxIndex = i;
                    }
                }
            }
            else if (parameter == "odd")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] >= maxValue && arr[i] %2 == 1)
                    {
                        maxValue = arr[i];
                        maxIndex = i;
                    }
                }
            }

            if (maxIndex != -1)
            {
                Console.WriteLine(maxIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
            
        }

        static void Min(string parameter, int[] arr)
        {
            int minIndex = -1;
            int minValue = int.MaxValue;
            if(parameter == "even")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] <= minValue && arr[i] % 2 == 0)
                    {
                        minValue = arr[i];
                        minIndex = i;
                    }
                }
                
            }
            else if (parameter == "odd")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] <= minValue && arr[i] % 2 == 1)
                    {
                        minValue = arr[i];
                        minIndex = i;
                    }
                }
                
            }

            if (minIndex != -1)
            {
                Console.WriteLine(minIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }




        }

        static void First(int count, string parameter, int[] arr)
        {
            
            if (count > arr.Length || count < 0)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            int counter = 0;
            int[] results = new int[0];
            string result = "[";
            if (parameter == "even")
            {
                
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        int[] oldResults = results;
                        results = new int[counter + 1];
                        Array.Copy(oldResults, results, oldResults.Length);
                        results[counter] = arr[i];
                        counter++;
                        if (counter == count)
                        { 
                            break;
                        }
                        
                    }
                }
            }
            else if (parameter == "odd")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 1)
                    {

                        int[] oldResults = results;
                        results = new int[counter + 1];
                        Array.Copy(oldResults, results, oldResults.Length);
                        results[counter] = arr[i];
                        counter++;
                        if (counter == count)
                        {
                            break;
                        }

                    }
                }
            }

            result += String.Join(", ", results);
            result += "]";
            Console.WriteLine(result);
        }

        static void Last(int count, string parameter, int[] arr)
        {

            if (count > arr.Length || count < 0)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int counter = 0;
            string result = "[";
            int[] results = new int[count];

            

            if (parameter == "even")
            {

                for (int i = arr.Length-1; i >= 0; i--)
                {
                    if (arr[i] % 2 == 0)
                    {
                        results[counter] = arr[i];
                        
                        counter++;
                        if (counter == count)
                        {
                            
                            break;
                        }
                        
                    }
                }

                if (counter < count)
                {
                    results = results[0..counter];
                }
            }

            else if (parameter == "odd")
            {
                for (int i = arr.Length-1; i >= 0; i--)
                {
                    if (arr[i] % 2 == 1)
                    {
                        results[counter] = arr[i];
                        counter++;
                        
                        if (counter == count)
                        {
                            
                            break;
                        }
                        
                    }
                }

                if (counter < count)
                {
                    results = results[0..counter];
                }
            }

            if (counter > 0)
            {
                int[] reversedResults = new int[counter];
                int reverseCounter = 1;
                for (int i = 0; i < results.Length; i++)
                {
                    reversedResults[reversedResults.Length - reverseCounter] = results[i];
                    reverseCounter++;
                }

                result += String.Join(", ", reversedResults);
            }
            
            result += "]";
            Console.WriteLine(result);
        }
    }
}
