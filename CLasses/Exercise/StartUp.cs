using Exercise;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Tire[]> tireList = new List<Tire[]>();
            while (input != "No more tires")
            {
               
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Tire[] tires = new Tire[4];


                int count = 0;
                for (int i = 0; i < 8; i+= 2)
                {
                    int year = int.Parse(tokens[i]);
                    double pressure = double.Parse(tokens[i + 1]);
                    tires[count] = new Tire(year ,pressure);
                    count++;
                }
                tireList.Add(tires);
                input = Console.ReadLine();
            }


            input = Console.ReadLine();
            List<Engine> engineList = new List<Engine>();
            while (input != "Engines done")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int horsePower = int.Parse(tokens[0]);
                double cubicCapacity = double.Parse(tokens[1]);
                engineList.Add(new Engine(horsePower, cubicCapacity));

                input = Console.ReadLine();

            }


            input = Console.ReadLine();
            List<Car> cars = new List<Car>();
            while (input != "Show special")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = tokens[0];
                string model = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQuantity = double.Parse(tokens[3]);
                double fuelConsumption = double.Parse(tokens[4]);
                int engineIndex = int.Parse(tokens[5]);
                int tiresIndex = int.Parse(tokens[6]);

                Engine engine = engineList[engineIndex];
                Tire[] tires = tireList[tiresIndex];
                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires ));


                input = Console.ReadLine();
            }
            List<Car> specialCars = cars
               .FindAll(c => c.Engine.HorsePower > 330
               && c.Tires.Select(t => t.Pressure).Sum() > 9
               && c.Tires.Select(t => t.Pressure).Sum() < 10);


            foreach (Car car in specialCars)
            {
                car.Drive(car.FuelQuantity, car.FuelConsumption);
                Console.WriteLine(car.ShowSpecial());
            }

        }


    }
}
