using System;
using System.Collections.Generic;
using System.Text;

namespace Raw_Data
{
    public class Car
    {
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public Car(string model, Engine engine, Cargo cargo, Tires[] tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }

        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tires[] Tires { get; set; }
    }
}
