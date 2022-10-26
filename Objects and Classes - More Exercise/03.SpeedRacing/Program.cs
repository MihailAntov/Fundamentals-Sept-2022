using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SpeedRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] carInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                cars.Add(new Car(carInput[0], decimal.Parse(carInput[1]), decimal.Parse(carInput[2])));
            }

            string input;
            while ((input = Console.ReadLine())!= "End")
            {
                string[] carCommand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car currentCar = cars.Find(n=> n.model == carCommand[1]);
                currentCar.TryToDrive(decimal.Parse(carCommand[2]));

            }

            foreach(Car car in cars)
            {
                Console.WriteLine($"{car.model} {car.fuel:f2} {car.distance}");
            }

        }
    }
    
    public class Car
    {
        public Car(string model, decimal fuel, decimal fuelPerKm)
        {
            this.model = model;
            this.fuel = fuel;
            this.fuelPerKm = fuelPerKm;
            
        }
        public string model;
        public decimal fuel;
        public decimal fuelPerKm;
        public decimal distance = 0;
        
        public void TryToDrive(decimal km)
        {
            if(this.fuelPerKm * km > fuel)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.fuel -= this.fuelPerKm * km;
                this.distance += km;
            }
        }
    }
}
