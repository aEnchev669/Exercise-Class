using _4._Border_Control.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _4._Border_Control.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}
