using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SortTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] inputTimes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            List<Time> times = new List<Time>();
            foreach(string input in inputTimes)
            {
                string[] cmdArgs = input.Split(':', StringSplitOptions.RemoveEmptyEntries);
                int hours = int.Parse(cmdArgs[0]);
                int minutes = int.Parse(cmdArgs[1]);

                times.Add(new Time(hours, minutes));
                    
            }

            times = times.OrderBy(n => n.Hours).ThenBy(n => n.Mintues).ToList();
            Console.WriteLine(String.Join(", ",times));

            
        }
    }


    public class Time
    {
        public Time(int hours, int mintues)
        {
            Hours = hours;
            Mintues = mintues;
        }

        public int Hours{ get; set; }
        public int Mintues { get; set; }
        public override string ToString()
        {
            return $"{Hours:d2}:{Mintues:d2}";
        }
    }
}
