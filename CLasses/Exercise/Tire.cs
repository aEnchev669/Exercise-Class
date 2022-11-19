using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class Tire
    {
        public int Year { get; set; }
        public double Pressure { get; set; }
        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }
    }
}
