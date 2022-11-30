
using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : IVehicles
    {
        public Truck()
        {

        }
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption + 1.6;
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
            if (FuelQuantity + liters > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                FuelQuantity += liters * 0.95;
            }
            
        }
    }
}
