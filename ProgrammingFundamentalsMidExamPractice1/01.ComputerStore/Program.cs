using System;

namespace _01.ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            decimal sum = 0;

            while ((input = Console.ReadLine()) != "special" && input != "regular")
            {
                decimal nextPrice = decimal.Parse(input);
                if( nextPrice <= 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }

                sum+= nextPrice;

            }

            

            if (sum == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {sum:f2}$");
            Console.WriteLine($"Taxes: {0.2M * sum:f2}$");
            Console.WriteLine("-----------");
            if (input == "special")
            {
                sum *= 0.9M;
            }

            Console.WriteLine($"Total price: {1.2M * sum:f2}$");
        }
    }
}
