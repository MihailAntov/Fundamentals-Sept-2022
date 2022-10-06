using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double pricePerPerson = 0;

            switch (type)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            pricePerPerson = 8.45;
                            break;
                        case "Saturday":
                            pricePerPerson = 9.80;
                            break;
                        case "Sunday":
                            pricePerPerson = 10.46;
                            break;
                    }
                    break;

                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            pricePerPerson = 10.90;
                            break;
                        case "Saturday":
                            pricePerPerson = 15.60;
                            break;
                        case "Sunday":
                            pricePerPerson = 16;
                            break;
                    }
                    break;

                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            pricePerPerson = 15;
                            break;
                        case "Saturday":
                            pricePerPerson = 20;
                            break;
                        case "Sunday":
                            pricePerPerson = 22.50;
                            break;
                    }
                    break;

            }

            if(type == "Students" && people >= 30)
            {
                pricePerPerson *= 0.85;
            }

            if(type == "Business" && people >=100)
            {
                people -= 10;
            }

            if (type == "Regular" && people >= 10 && people <= 20)
            {
                pricePerPerson *= 0.95;
            }

            double total = pricePerPerson * people;

            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
