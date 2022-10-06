using System;
using System.Linq;

namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            int sum = 0;
            foreach (int n in firstArray)
            {
                sum += n;
            }


            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    if(i == firstArray.Length - 1)
                    {
                        Console.WriteLine($"Arrays are identical. Sum: {sum}");
                    }
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                
            }

        }
    }
}
