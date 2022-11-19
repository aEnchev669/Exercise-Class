using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class Engine
    {
        public double HorsePower { get; set; }
        public double CubicCapacity { get; set; }
        public Engine()
        {

        }
        public Engine(double horsePower, double cubiccapacity) : this()
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubiccapacity;
        }
    }
}
