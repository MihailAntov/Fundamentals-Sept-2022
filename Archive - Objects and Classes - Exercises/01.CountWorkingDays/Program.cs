using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _01.CountWorkingDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string format = "dd-MM-yyyy";
            DateTime start = DateTime.ParseExact(Console.ReadLine(),format,CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
            var dates = DateRange(start, end);
            List<string> holidays = new List<string>
            {
                {"1 1" },
                {"3 3" },
                {"1 5" },
                {"6 5" },
                {"24 5" },
                {"6 9" },
                {"22 9" },
                {"1 11" },
                {"24 12" },
                {"25 12" },
                {"26 12" }
                
            };
            List<DateTime> filteredDates = dates.Where(n=>
            n.DayOfWeek != DayOfWeek.Sunday &&
            n.DayOfWeek != DayOfWeek.Saturday && 
            !holidays.Contains($"{n.Day} {n.Month}"))
                .ToList();
            Console.WriteLine(filteredDates.Count());
        }

        public static IEnumerable<DateTime> DateRange(DateTime startDate, DateTime endDate)
        {
            return Enumerable.Range(0, (endDate - startDate).Days + 1).Select(d => startDate.AddDays(d));
        }
    }


}
