﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const  double DEFAULT_FUEL_CONSUMPTION = 1.25;
        public virtual double FuelConsumption => DEFAULT_FUEL_CONSUMPTION;
        
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        public int HorsePower { get; set; }
        public double Fuel { get; set; }

        public virtual void Drive(double kilometers)
        {
            double fuelLeft = this.Fuel - kilometers * this.FuelConsumption;

            if (fuelLeft >=0)
            {
                this.Fuel = fuelLeft;
            }
        }
        
    }
}
