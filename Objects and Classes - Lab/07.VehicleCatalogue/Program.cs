using System;
using System.Collections.Generic;
using System.Linq;
namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Catalog catalog = new Catalog();
            catalog.collectionOfTrucks = new List<Truck>();
            catalog.collectionOfCars = new List<Car>();
            while ((input = Console.ReadLine())!= "end")
            {
                string[] cmdArgs = input.Split("/", StringSplitOptions.RemoveEmptyEntries);
                if (cmdArgs[0] == "Car")
                {
                    catalog.collectionOfCars.Add(new Car(cmdArgs[1], cmdArgs[2], double.Parse(cmdArgs[3])));   
                }
                else if (cmdArgs[0] == "Truck")
                {
                    catalog.collectionOfTrucks.Add(new Truck(cmdArgs[1], cmdArgs[2], double.Parse(cmdArgs[3])));
                }
            }
            if(catalog.collectionOfCars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in catalog.collectionOfCars.OrderBy(c => c.brand))
                {
                    Console.WriteLine($"{car.brand}: {car.model} - {car.horsePower}hp");
                }
            }

            if (catalog.collectionOfTrucks.Count >0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in catalog.collectionOfTrucks.OrderBy(c => c.brand))
                {
                    Console.WriteLine($"{truck.brand}: {truck.model} - {truck.weight}kg");
                }
            }
            
            
        }
    }

    public class Truck
    {
        public Truck(string _brand, string _model, double _weight)
        {
            brand = _brand;
            model = _model;
            weight = _weight;
        }
        public string brand;
        public string model;
        public double weight;
    }

    public class Car
    {
        public string brand;
        public string model;
        public double horsePower;

        public Car(string _brand, string _model, double _horsePower)
        {
            brand = _brand;
            model = _model;
            horsePower = _horsePower;
        }
    }

    public class Catalog
    {
        public List<Car> collectionOfCars;
        public List<Truck> collectionOfTrucks;
    }
}
