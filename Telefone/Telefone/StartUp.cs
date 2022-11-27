using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string[] urls = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            foreach (var number in phoneNumbers)
            {
                if (number.Length == 10)
                {
                    smartphone.Calling(number);
                }
                else
                {
                    stationaryPhone.Calling(number);
                }
            }

            smartphone.Browsing(urls);
        }
    }
}
