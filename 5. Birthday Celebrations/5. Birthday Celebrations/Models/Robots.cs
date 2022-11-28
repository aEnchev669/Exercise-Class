using _4._Border_Control.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _4._Border_Control.Models
{
    public class Robots : IRobot
    {
        public Robots(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; private set; }

        public string Id { get; private set; }
    }
}
