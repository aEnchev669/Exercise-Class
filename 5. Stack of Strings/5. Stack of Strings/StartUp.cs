using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings strings = new StackOfStrings();

            strings.AddRange(new List<string>() { "1", "2", "3", "4", "5" });

            while (!strings.IsEmpty())
            {
                Console.WriteLine(strings.Pop());
            }

            Console.WriteLine(strings.IsEmpty());
        }
    }
}
