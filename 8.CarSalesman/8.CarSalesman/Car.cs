using System;
using System.Collections.Generic;
using System.Text;

namespace _8.CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public Car(string model, Engine engine, int weight): this(model, engine)
        {
            Weight = weight;
        }

        public Car(string model, Engine engine, string color) : this(model, engine)
        { 
            Color = color;
        }

        public Car(string model, Engine engine, int weight, string color) : this(model, engine, weight)
        {
            Color = color;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            string weight = this.Weight == 0 ? "n/a" : this.Weight.ToString();
            string color = this.Color == null ? "n/a" : this.Color.ToString();

            sb.AppendLine($"{this.Model}:")
              .AppendLine($"  {this.Engine.ToString()}")
              .AppendLine($"  Weight: {weight}")
              .AppendLine($"  Color: {color}");

            return sb.ToString().Trim();
        }
    }
}
