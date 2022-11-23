using System;
using System.Collections.Generic;
using System.Text;

namespace Raw_Data
{
    public class Engine
    {
        private int speed;

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        private int power;
        public Engine(int speed,  int power)
        {
            Speed = speed;
            Power = power;
        }

        public int Power
        {
            get { return power; }
            set { power = value; }
        }


    }
}
