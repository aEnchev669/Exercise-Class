using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : IStationaryPhone
    {
        
        public void Calling(string number)
        {
            if (IsValidNumber(number))
            {
                Console.WriteLine($"Dialing... {number}"); ;
            }
            else
            {
                Console.WriteLine($"Invalid number!");
            }
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
