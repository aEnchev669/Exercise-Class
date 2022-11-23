using System;
using System.Collections.Generic;
using System.Linq;

namespace Raw_Data
{
    public class Program
    {
        static void Main(string[] args)
        {
            int nCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < nCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                int speed = int.Parse(carInfo[1]);
                int power = int.Parse(carInfo[2]);
                int weight = int.Parse(carInfo[3]);
                string type = carInfo[4];

                double pressure1 = double.Parse(carInfo[5]);
                int age1 = int.Parse(carInfo[6]);

                double pressure2 = double.Parse(carInfo[7]);
                int age2 = int.Parse(carInfo[8]);

                double pressure3 = double.Parse(carInfo[9]);
                int age3 = int.Parse(carInfo[10]);

                double pressure4 = double.Parse(carInfo[11]);
                int age4 = int.Parse(carInfo[12]);

                Engine engine = new Engine(speed, power);
                Cargo cargo = new Cargo(weight, type);
                Tires[] tires = new Tires[4]
                {
                    new Tires(age1,pressure1),
                    new Tires(age2,pressure2),
                    new Tires(age3,pressure3),
                    new Tires(age4,pressure4),
                };

                Car car = new Car(model, engine, cargo, tires);
               
                cars.Add(car);
            }

            string typeNeeded = Console.ReadLine();

            if (typeNeeded == "flammable")
            {
                List<Car> flammable = cars.FindAll(c => c.Cargo.Type == "flammable" &&  c.Engine.Power > 250);
                foreach (var car in flammable)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (typeNeeded == "fragile")
            {
                List<Car> fragile = cars.FindAll(c => c.Cargo.Type == "fragile" && c.Tires.Any(p => p.Pressure < 1));
                foreach (var car in fragile)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
