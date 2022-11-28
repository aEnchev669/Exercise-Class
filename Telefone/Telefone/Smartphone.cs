using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : ISmartphone
    {
        
        public void Browsing(string[] urls)
        {
            foreach (var item in urls)
            {
                if (IsValid(item))
                {
                    Console.WriteLine($"Browsing: {item}!");
                }
                else
                {
                    Console.WriteLine($"Invalid URL!");
                }
            }
        }

        public void Calling(string number)
        {
            Console.WriteLine($"Calling... {number}");
        }

        public bool IsValid(string url) => url.Any(u => char.IsDigit(u));
    }
}
