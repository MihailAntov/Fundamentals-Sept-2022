using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Vehicle> vehicles = new List<Vehicle>();
            while ((input = Console.ReadLine())!= "End")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                vehicles.Add(new Vehicle(cmdArgs[0], cmdArgs[1], cmdArgs[2], int.Parse(cmdArgs[3])));
            }

            string secondLineInput;
            while ((secondLineInput = Console.ReadLine())!= "Close the Catalogue")
            {
                Vehicle currentlyDisplayedVehicle = vehicles.Find(n => n.Model == secondLineInput);
                Console.WriteLine($"Type: {currentlyDisplayedVehicle.Type}");
                Console.WriteLine($"Model: {currentlyDisplayedVehicle.Model}");
                Console.WriteLine($"Color: {currentlyDisplayedVehicle.Color}");
                Console.WriteLine($"Horsepower: {currentlyDisplayedVehicle.HorsePower}");
            }

            double totalCarHP = 1.0 * vehicles.Where(n => n.Type == "Car").Select(n => n.HorsePower).Sum();
            double totalCarCount =1.0 * vehicles.Where(n => n.Type == "Car").Count();
            

            double totalTruckHP = 1.0 * vehicles.Where(n => n.Type == "Truck").Select(n => n.HorsePower).Sum();
            double totalTruckCount = 1.0 * vehicles.Where(n => n.Type == "Truck").Count();

            if(totalCarCount == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {0.0:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {totalCarHP/totalCarCount:f2}.");
            }

            if (totalTruckCount == 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {0.0:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {totalTruckHP / totalTruckCount:f2}.");
            }

            
            
        }
    }

    public class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {

            this.Type = type[0].ToString().ToUpper() + type.Substring(1);
            this.Model = model[0].ToString().ToUpper() + model.Substring(1);
            this.Color = color;
            this.HorsePower = horsePower;
        }

        public string Type { get; private set; }
        public string Model { get; private set; }
        public string Color { get; private set; }
        public int HorsePower { get; private set; }

    }
}
