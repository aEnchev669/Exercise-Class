
using System;
using System.Collections.Generic;
using System.Text;
using Vehicles;

namespace _2.VehiclesExtension
{
    public class Bus : IVehicles
    {
        public Bus()
        {

        }
        public Bus(double fuelQuantity, double fuelConsupmtion, double tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsupmtion;
            TankCapacity = tankCapacity;
        }
        public double TankCapacity { get; private set; }
        public double FuelQuantity { get; private set; }


        public double FuelConsumption { get; private set; }

        public void Drive(double km)
        {
            double quantity = FuelQuantity - FuelConsumption * km;
            if (quantity < 0)
            {
                Console.WriteLine("Bus needs refueling");
            }
            else if (quantity >= 0)
            {
                FuelQuantity = quantity;
                Console.WriteLine($"Bus travelled {km} km");
            }
        }
        public void DriveFull(double km)
        {
            double quantity = FuelQuantity - (FuelConsumption + 1.4) * km;
            if (quantity < 0)
            {
                Console.WriteLine("Bus needs refueling");
            }
            else if (quantity >= 0)
            {
                FuelQuantity = quantity;
                Console.WriteLine($"Bus travelled {km} km");
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
