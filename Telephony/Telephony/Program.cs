﻿using System;
using Telephony.Core;
using Telephony.IO;
using Telephony.IO.Interfaces;

namespace Telephony
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
