using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            decimal total = 0;
            string regex = @"%(?<customer>[A-Z][a-z]+)%.*<(?<product>\w+)>.*\|(?<quantity>[0-9]+)\|\D*(?<price>[0-9\.]+)\$";
            while ((input = Console.ReadLine())!= "end of shift")
            {
               Match validOrder = Regex.Match(input, regex);
                if(validOrder.Success)
                {
                    string customer = validOrder.Groups["customer"].Value;
                    string product = validOrder.Groups["product"].Value;
                    int quantity =int.Parse(validOrder.Groups["quantity"].Value);
                    decimal price = decimal.Parse(validOrder.Groups["price"].Value);

                    Console.WriteLine($"{customer}: {product} - {price*quantity:f2}");
                    total += price * quantity;
                }
            }
            Console.WriteLine($"Total income: {total:f2}");
        }
    }

    
}
