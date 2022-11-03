using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace _02.AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string filter = @"([|#])(?<name>[a-zA-Z\s]+)\1(?<day>\d\d)\/(?<month>\d\d)\/(?<year>\d\d)+\1(?<calories>[\d]{1,5})\1";

            MatchCollection food = Regex.Matches(text, filter);

            int totalCalories = food.Select(n => int.Parse(n.Groups["calories"].Value)).Sum();

            int days = totalCalories / 2_000;

            //problem description states 2000 kcal, which is 2_000_000 calories,
            //but it would appear they mean 2000 cal
            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach(Match m in food)
            {
                string name = m.Groups["name"].Value;
                string expiration = $"{m.Groups["day"].Value}/{m.Groups["month"].Value}/{m.Groups["year"].Value}";
                string calories = m.Groups["calories"].Value;

                Console.WriteLine($"Item: {name}, Best before: {expiration}, Nutrition: {calories}");
            }

        }
    }
}
