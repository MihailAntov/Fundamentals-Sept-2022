using System;

namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            decimal nextCoin = 0;
            decimal balance = 0;
            decimal priceOfProduct = 0;
            while (input != "Start")
            {
                input = Console.ReadLine();
                if(input == "Start")
                {
                    break;
                }
                nextCoin = decimal.Parse(input);
                switch (nextCoin)
                {
                    case 0.1m:
                    case 0.2m:
                    case 0.5m:
                    case 1m:
                    case 2m:
                        balance += nextCoin;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {nextCoin}");
                        break;
                }
            }

            input = "";
            while (input != "End")
            {
                choice:
                input = Console.ReadLine();
                switch (input)
                {
                    case "Nuts":
                        priceOfProduct = 2.0M;
                    break;
                    case "Water":
                        priceOfProduct = 0.7M;
                        break;
                    case "Crisps":
                        priceOfProduct = 1.5M;
                        break;
                    case "Soda":
                        priceOfProduct = 0.8M;
                        break;
                    case "Coke":
                        priceOfProduct = 1.0M;
                        break;
                    case "End":
                        Console.WriteLine($"Change: {balance:f2}");
                        return;

                    default:
                        Console.WriteLine("Invalid product");
                        goto choice;
                        
                        
                }
                if (priceOfProduct <= balance)
                {
                    balance -= priceOfProduct;
                    Console.WriteLine($"Purchased {input.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }


            }
        }
    }
}
