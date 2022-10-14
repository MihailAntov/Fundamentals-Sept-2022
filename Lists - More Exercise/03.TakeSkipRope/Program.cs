using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.TakeSkipRope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> numbers = input
                .Where(n => char.IsDigit(n))
                .Select(n=>n.ToString())
                .Select(n=>int.Parse(n))
                .ToList();

            List<char> chars = input
                .Where(n => !char.IsDigit(n))
                .ToList();

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if(i%2==0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            string result = String.Empty;
            int toSkip = 0;
            

            for (int i = 0; i < takeList.Count; i++)
            {




                //result += String.Concat(chars.Take(takeList[i]));
                //chars = chars.Skip(takeList[i]).ToList();
                
                result += String.Concat(chars.Skip(toSkip).Take(takeList[i]).ToList());
                toSkip += skipList[i] + takeList[i];




                //result += String.Concat(chars.Skip(toSkip + skipList[i]).Take(takeList[i]+toSkip));




            }

            Console.WriteLine(result);
        }
    }
}

