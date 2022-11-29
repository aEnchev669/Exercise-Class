using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : IVehicles
    {
        public Car(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption + 0.9;
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; private set; }

        public void Drive(double km)
        {
            double quantity = FuelQuantity - FuelConsumption * km;
            if (quantity < 0)
            {
                Console.WriteLine("Car needs refueling");
            }
            else if (quantity >= 0)
            {
                FuelQuantity = quantity;
                Console.WriteLine($"Car travelled {km} km");
            }

        }

        public void Refuel(double liters)
        {
            FuelQuantity += liters;
        }
    }
}
