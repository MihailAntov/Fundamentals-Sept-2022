using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.RawData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] carInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                cars.Add(new Car(carInput[0],
                    int.Parse(carInput[1]),
                    int.Parse(carInput[2]),
                    int.Parse(carInput[3]),
                    carInput[4]));
            }

            string command = Console.ReadLine();
            if(command == "fragile")
            {
                foreach(Car car in cars.Where(n=>n.cargo.type == "fragile" && n.cargo.weight < 1000))
                {
                    Console.WriteLine(car.model);
                }
            }
            else if (command == "flamable")
            {
                foreach(Car car in cars.Where(n=>n.cargo.type == "flamable" && n.engine.power > 250))
                {
                    Console.WriteLine(car.model);
                }
            }
        }
    }

    public class Car
    {
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType)
        {
            this.model = model;
            this.engine = new Engine(engineSpeed, enginePower);
            this.cargo = new Cargo(cargoWeight, cargoType);
        }

        public string model;
        public Engine engine;
        public Cargo cargo;

    }

    public class Engine
    {
        public Engine(int speed, int power)
        {
            this.speed = speed;
            this.power = power;
        }
        public int speed;
        public int power;
    }

    public class Cargo
    {
        public Cargo(int weight, string type)
        {
            this.weight = weight;
            this.type = type;
        }
        public int weight;
        public string type;
        
    }
}
