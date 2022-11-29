using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : IVehicles
    {
        public Truck(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption + 1.6;
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; private set; }

        public void Drive(double km)
        {
            double quantity = FuelQuantity - FuelConsumption * km;
            if (quantity < 0)
            {
                Console.WriteLine("Truck needs refueling");
            }
            else if (quantity >= 0)
            {
                FuelQuantity = quantity;
                Console.WriteLine($"Truck travelled {km} km");
            }

        }

        public void Refuel(double liters)
        {
            FuelQuantity += liters * 0.95;
        }
    }
}
