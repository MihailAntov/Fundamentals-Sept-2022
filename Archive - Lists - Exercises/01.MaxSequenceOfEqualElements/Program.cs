//regular solution

//using System;
//using System.Linq;
//using System.Text;
//using System.Collections.Generic;

//namespace _01.MaxSequenceOfEqualElements
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] ints = Console.ReadLine()
//                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
//                .Select(n => int.Parse(n))
//                .ToArray();
//            int bestStart = -1;
//            int bestLength = -1;
//            int counter = 0;
//            for (int i = 0; i < ints.Length; i++)
//            {

//                if (i > 0)
//                {
//                    if (ints[i] != ints[i - 1])
//                    {
//                        counter = 0;
//                    }
//                }

//                counter++;
//                if (counter > bestLength)
//                {
//                    bestLength = counter;
//                    bestStart = i;
//                }
//            }

//            for(int i =0; i < bestLength; i++)
//            {
//                Console.Write(ints[bestStart]+" ");
//            }


//        }
//    }
//}


//weird needlessly complicated solution
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _01.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            List<(int, int)> results = new List<(int, int)>();

            int lengthCounter = 1;

            for (int i = 1; i < ints.Length; i++)
            {
                if (ints[i] == ints[i - 1])
                {
                    lengthCounter++;
                }
                else
                {
                    results.Add((ints[i - 1], lengthCounter));
                    lengthCounter = 1;
                }

                if (i == ints.Length - 1)
                {
                    results.Add((ints[i], lengthCounter));
                }
            }

            if (ints.Length == 1)
            {
                results.Add((ints[0], 1));
            }

            var finalResult = results
                .FirstOrDefault(n => n.Item2 == results.Select(n => n.Item2).Max());
            int number = finalResult.Item1;
            int count = finalResult.Item2;
            StringBuilder toBePrinted = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                toBePrinted.Append(number);
                if (i != count - 1)
                {
                    toBePrinted.Append(' ');
                }
            }

            Console.WriteLine(toBePrinted);


        }
    }
}

