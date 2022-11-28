using _4._Border_Control.Core;
using _4._Border_Control.IO;
using _4._Border_Control.IO.Interfaces;
using System;

namespace _6.FoodShortage
{
    public class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            Engine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
