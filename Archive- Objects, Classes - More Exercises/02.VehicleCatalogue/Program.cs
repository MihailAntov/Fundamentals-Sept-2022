using System;
using System.Collections.Generic;
using System.Linq;
namespace _02.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Vehicle> vehicles = new List<Vehicle>();
            while((input = Console.ReadLine()) != "End")
            {
                string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = inputArgs[0].ToLower();
                string model = inputArgs[1].ToLower();
                string color = inputArgs[2].ToLower();
                double horsepower = double.Parse(inputArgs[3]);

                vehicles.Add(new Vehicle(type, model, color, horsepower));
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                string modelQuery = input.Trim();
                Vehicle vehicle = vehicles.FirstOrDefault(n => n.Model == modelQuery);
                Console.WriteLine(vehicle);
                
            }

            double avgCarHP = 0;
            double avgTruckHP = 0;

            if(vehicles.Where(n=>n.Type=="Car").Count() != 0)
            {
                avgCarHP = vehicles.Where(n => n.Type == "Car").Select(n => n.Horsepower).Sum() * 1.0 / vehicles.Where(n => n.Type == "Car").Count();
            }
            
            if(vehicles.Where(n=>n.Type=="Truck").Count()!= 0)
            {
                avgTruckHP = vehicles.Where(n => n.Type == "Truck").Select(n => n.Horsepower).Sum() * 1.0 / vehicles.Where(n=>n.Type == "Truck").Count();
            }



            Console.WriteLine($"Cars have average horsepower of: {avgCarHP:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avgTruckHP:f2}.");
        }
    }

    public class Vehicle
    {
        public Vehicle(string type, string model, string color, double horsepower)
        {
            Type = type[0].ToString().ToUpper() + type.Substring(1);
            Model = model[0].ToString().ToUpper() + model.Substring(1);
            Color = color.ToLower();
            Horsepower = horsepower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Horsepower { get; set; }
        public override string ToString()
        {
            return $"Type: {Type}\nModel: {Model}\nColor: {Color}\nHorsepower: {Horsepower}";
        }
    }
}
