using System;
using System.Collections.Generic;
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
            if (IsValidNumber(number))
            {
                Console.WriteLine($"Calling... {number}");
            }
            else
            {
                Console.WriteLine($"Invalid number!");
            }
        }

        public bool IsValid(string url)
        {
            foreach (char item in url)
            {
                if (char.IsDigit(item))
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsValidNumber(string number)
        {
            foreach (var item in number)
            {
                if (!char.IsDigit(item))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
