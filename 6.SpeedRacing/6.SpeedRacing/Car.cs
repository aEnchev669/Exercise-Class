using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private double fuelAmount;

        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }

        private double fuelConsumptionPerKilometer;

        public double FuelConsumptionPerKilometer
        {
            get { return fuelConsumptionPerKilometer; }
            set { fuelConsumptionPerKilometer = value; }
        }

        private double travelledDistance;

        public double TravelledDistance
        {
            get { return travelledDistance; }
            set { travelledDistance = value; }
        }
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TravelledDistance = 0;
        }
        public void Drive(double kmAmount)
        {
            double fuelNeeded = FuelConsumptionPerKilometer * kmAmount;
            if (fuelNeeded <= fuelAmount)
            {
                this.FuelAmount -= (FuelConsumptionPerKilometer * kmAmount);
                this.travelledDistance += kmAmount;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }



    }
}
