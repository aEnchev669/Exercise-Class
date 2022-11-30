
using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : IVehicles
    {
        public Car()
        {

        }
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption + 0.9;
            TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; private set; }
        public double TankCapacity { get; private set; }
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
            if (FuelQuantity + liters > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                FuelQuantity += liters;
            }
        }
    }
}
