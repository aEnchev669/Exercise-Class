using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double lenght;

        public double Length
        {
            get { return lenght; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Length)} cannot be zero or negative.");
                }
                lenght = value;
            }
        }
        private double width;

        public double Width
        {
            get { return width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Width)} cannot be zero or negative.");
                }
                width = value;
            }
        }
        private double height;

        public double Height
        {
            get { return height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Height)} cannot be zero or negative.");
                }
                height = value;
            }
        }

        public Box(double lenght, double width, double height)
        {
            Length = lenght;
            Width = width;
            Height = height;
        }

        public double SurfaceArea()
        {
            return (2 * Length * Width) + (2 * Length * Height) + (2 * Width * Height);
        }
        public double LateralSurfaceArea()
        {
            return (2 * Length * Height) + (2 * Width * Height);
        }
        public double Volume()
        {
            return Length * Height * Width;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Surface Area - {SurfaceArea():f2}")
           .AppendLine($"Lateral Surface Area - {LateralSurfaceArea():f2}")
            .AppendLine($"Volume - {Volume():f2}");

            return sb.ToString();
        }
    } 
}
