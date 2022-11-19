using System;
using System.Collections.Generic;
using System.Text;

namespace CLasses
{
    public class Engine
    {
        public double CubicCapacity { get; set; }
        public int HorsePower { get; set; }

        public Engine( int horsePower,double cubicCapacity)
        {
            CubicCapacity = cubicCapacity;
            HorsePower = horsePower;
        }
    }
}
