using System;
using System.Linq;

namespace _05.LongestIncreasingSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] bestLength = new int[numbers.Length];
            int maxSequence = -1;
            int maxSequenceIndex = -1;
            

            for (int currentIndex = numbers.Length-1; currentIndex >=0; currentIndex--)
            {
                if(currentIndex == numbers.Length-1)
                {
                    bestLength[currentIndex] = 1;
                }
                else
                {
                    int currentSequence = 1;
                    for (int j = currentIndex +1; j < numbers.Length; j++)
                    {
                        if (numbers[j] > numbers[currentIndex] && bestLength[j] >= currentSequence)
                        {
                            currentSequence = bestLength[j] + 1;
                        }
                    }
                    bestLength[currentIndex] = currentSequence;
                    if (currentSequence >= maxSequence)
                    {
                        maxSequence = currentSequence;
                        maxSequenceIndex = currentIndex;

                    }


                }
            }

            for (int i = maxSequenceIndex; i < numbers.Length; i++)
            {
                if (maxSequence == bestLength[i])
                {
                    Console.Write(numbers[i] +" ");
                    maxSequence--;
                }
            }

            

            

            



        }
    }
}
