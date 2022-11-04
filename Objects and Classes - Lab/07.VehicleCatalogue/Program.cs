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
            while ((input = Console.ReadLine())!= "end")
            {
                string[] cmdArgs = input.Split("/", StringSplitOptions.RemoveEmptyEntries);
                if (cmdArgs[0] == "Car")
                {
                    catalog.CollectionOfCars.Add(new Car(cmdArgs[1], cmdArgs[2], double.Parse(cmdArgs[3])));   
                }
                else if (cmdArgs[0] == "Truck")
                {
                    catalog.CollectionOfTrucks.Add(new Truck(cmdArgs[1], cmdArgs[2], double.Parse(cmdArgs[3])));
                }
            }
            if(catalog.CollectionOfCars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in catalog.CollectionOfCars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalog.CollectionOfTrucks.Count >0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in catalog.CollectionOfTrucks.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
            
            
        }
    }

    public class Truck
    {
        public Truck(string brand, string model, double weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public double Weight { get; private set; }
    }

    public class Car
    {
        public Car(string brand, string model, double horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public double HorsePower { get; private set; }


    }

    public class Catalog
    {
        private List<Car> collectionOfCars;
        private List<Truck> collectionOfTrucks;
        public Catalog()
        {
            this.collectionOfCars = new List<Car>();
            this.collectionOfTrucks = new List<Truck>();
        }

        public List<Car> CollectionOfCars => this.collectionOfCars;
        public List<Truck> CollectionOfTrucks => this.collectionOfTrucks;
    }
}
