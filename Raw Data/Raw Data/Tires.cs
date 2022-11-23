using System;
using System.Collections.Generic;
using System.Text;

namespace Raw_Data
{
    public class Tires
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private double pressure;

        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }


        public Tires(int age,  double pressure)
        {
            Age = age;
            Pressure = pressure;
        }
    }
}
