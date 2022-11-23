using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();    
            int countOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumption = double.Parse(carInfo[2]);
                Car car = new Car(model, fuelAmount, fuelConsumption);

                cars.Add(model, car);
            }

            string cmd = Console.ReadLine();
            while (cmd != "End")
            {
                string[] tokens = cmd.Split();
                if (tokens[0] == "Drive")
                {
                    string model = tokens[1];
                    double travelledDIstance = double.Parse(tokens[2]);
                    cars[model].Drive(travelledDIstance);
                }
                cmd = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Value.Model} {(car.Value.FuelAmount):f2} {car.Value.TravelledDistance}");
            }
        }
    }
}
