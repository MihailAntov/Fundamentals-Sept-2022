using System;
using System.Collections.Generic;

namespace _03.NeedForSpeedIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                string car = inputArgs[0];
                int mileage = int.Parse(inputArgs[1]);
                int fuel = int.Parse(inputArgs[2]);

                if(!cars.ContainsKey(car))
                {
                    cars.Add(car, new Car(car, mileage, fuel));
                }
            }

            string input;

            while((input = Console.ReadLine())!= "Stop")
            {
                string[] cmdArgs = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                Car car = cars[cmdArgs[1]];

                switch (command)
                {
                    case "Drive":
                        int distance = int.Parse(cmdArgs[2]);
                        int fuel = int.Parse(cmdArgs[3]);
                        if(car.Fuel < fuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                            continue;
                        }
                        else
                        {
                            car.Fuel -= fuel;
                            car.Mileage += distance;
                            Console.WriteLine($"{car.Name} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                            if(car.Mileage >= 100_000)
                            {
                                Console.WriteLine($"Time to sell the {car.Name}!");
                                cars.Remove(car.Name);
                            }
                        }

                        break;
                    case "Refuel":
                        int fuelToAdd = int.Parse(cmdArgs[2]);

                        int fuelAdded = Math.Min(fuelToAdd, 75 - car.Fuel);
                        car.Fuel += fuelAdded;
                        Console.WriteLine($"{car.Name} refueled with {fuelAdded} liters");
                        break;
                    case "Revert":
                        int kms = int.Parse(cmdArgs[2]);
                        if(car.Mileage - kms <10_000)
                        {
                            car.Mileage = 10_000;
                        }
                        else
                        {
                            car.Mileage -= kms;
                            Console.WriteLine($"{car.Name} mileage decreased by {kms} kilometers");
                        }
                       
                        break;
                }
            }

            foreach(KeyValuePair<string, Car> car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.");
            }
        }
    }

    public class Car
    {
        public Car(string name, int mileage, int fuel)
        {
            Name = name;
            Mileage = mileage;
            Fuel = fuel;
        }

        public string Name { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
}
