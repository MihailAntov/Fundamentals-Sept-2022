using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _04.Weather
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string pattern = @"(?<city>[A-Z]{2})(?<temperature>\d+.\d+)(?<type>[A-Za-z]+)\|";
            Regex regex = new Regex(pattern);
            Dictionary<string, Forecast> cities = new Dictionary<string, Forecast>();
            while((input = Console.ReadLine())!= "end")
            {
                Match match = regex.Match(input);
                if(match.Success)
                {
                    string city = match.Groups["city"].Value;
                    double temp = double.Parse(match.Groups["temperature"].Value);
                    string type = match.Groups["type"].Value;

                    if(!cities.ContainsKey(city))
                    {
                        cities.Add(city, new Forecast(string.Empty, 0));
                    }
                    cities[city].Temp = temp;
                    cities[city].Type = type;
                    
                }
            }

            foreach (KeyValuePair<string, Forecast> city in cities.OrderBy(n=>n.Value.Temp))
            {
                Console.WriteLine($"{city.Key} => {city.Value.Temp} => {city.Value.Type}");
            }
        }
    }

    public class Forecast
    {
        public Forecast(string type, double temp)
        {
            Type = type;
            Temp = temp;
        }

        public string Type { get; set; }
        public double Temp { get; set; }
    }
}
