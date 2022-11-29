using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public interface IVehicles
    {
        public double FuelQuantity { get;}
        public double FuelConsumption { get;}
        public void Drive(double km);
        public void Refuel(double liters);
    }
}
