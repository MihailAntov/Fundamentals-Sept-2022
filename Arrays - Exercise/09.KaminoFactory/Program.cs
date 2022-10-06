using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dna = new int[n];
            int sample = 0;
            string input = String.Empty;
            int sumOfBestSequence = 0;
            int startingIndexOfBestSequence = -1;
            int lengthOfBestSequence = 0;
            int bestSample = 1;

            while (input != "Clone them!")
            {
                input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }
                sample++;




                int[] thisSequence = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
                int sumOfThisSequence = 0;
                int startingIndexOfThisSequence = n + 1;
                int lengthOfThisSequence = 0;
                int bestLengthOfThisSequence = 0;
                int bestIndexOfThisSequence = n + 1;
                for (int i = 0; i < n; i++)
                {

                    if (thisSequence[i] != 1)
                    {
                        lengthOfThisSequence = 0;
                        startingIndexOfThisSequence = n + 1;
                        continue;

                        
                    }

                    sumOfThisSequence++;
                    lengthOfThisSequence++;
                    if (startingIndexOfThisSequence == n + 1)
                    {
                        startingIndexOfThisSequence = i;
                    }

                    if (lengthOfThisSequence > bestLengthOfThisSequence)
                    {
                        bestLengthOfThisSequence = lengthOfThisSequence;

                        bestIndexOfThisSequence = startingIndexOfThisSequence;

                    }


                }

                if (bestLengthOfThisSequence > lengthOfBestSequence)
                {
                    dna = thisSequence;
                    lengthOfBestSequence = bestLengthOfThisSequence;
                    startingIndexOfBestSequence = bestIndexOfThisSequence;
                    sumOfBestSequence = sumOfThisSequence;
                    bestSample = sample;
                }
                else if (bestLengthOfThisSequence == lengthOfBestSequence)
                {
                    if (bestIndexOfThisSequence < startingIndexOfBestSequence)
                    {
                        dna = thisSequence;
                        lengthOfBestSequence = bestLengthOfThisSequence;
                        startingIndexOfBestSequence = bestIndexOfThisSequence;
                        sumOfBestSequence = sumOfThisSequence;
                        bestSample = sample;

                    }
                    else if (bestIndexOfThisSequence == startingIndexOfBestSequence)
                    {
                        if (sumOfThisSequence > sumOfBestSequence)
                        {
                            dna = thisSequence;
                            lengthOfBestSequence = bestLengthOfThisSequence;
                            startingIndexOfBestSequence = bestIndexOfThisSequence;
                            sumOfBestSequence = sumOfThisSequence;
                            bestSample = sample;

                        }
                    }
                }


            }
            

            string result = string.Join(' ', dna);
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {sumOfBestSequence}.");
            Console.WriteLine(result);


        }
    }
}


