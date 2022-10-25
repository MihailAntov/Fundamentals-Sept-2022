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
                Vehicle currentlyDisplayedVehicle = vehicles.Find(n => n.model == secondLineInput);
                Console.WriteLine($"Type: {currentlyDisplayedVehicle.type}");
                Console.WriteLine($"Model: {currentlyDisplayedVehicle.model}");
                Console.WriteLine($"Color: {currentlyDisplayedVehicle.color}");
                Console.WriteLine($"Horsepower: {currentlyDisplayedVehicle.horsePower}");
            }

            double totalCarHP = 1.0 * vehicles.Where(n => n.type == "Car").Select(n => n.horsePower).Sum();
            double totalCarCount =1.0 * vehicles.Where(n => n.type == "Car").Count();
            

            double totalTruckHP = 1.0 * vehicles.Where(n => n.type == "Truck").Select(n => n.horsePower).Sum();
            double totalTruckCount = 1.0 * vehicles.Where(n => n.type == "Truck").Count();

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
        public string type;
        public string model;
        public string color;
        public int horsePower;
        public Vehicle(string type, string model, string color, int horsePower)
        {

            this.type = type[0].ToString().ToUpper() + type.Substring(1);
            this.model = model[0].ToString().ToUpper() + model.Substring(1);
            this.color = color;
            this.horsePower = horsePower;
        }
    }
}
