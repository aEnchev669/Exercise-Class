using System;
using System.Collections.Generic;
using System.Text;
using Telephony.Core.Interfaces;
using Telephony.Exceptions;
using Telephony.IO.Interfaces;
using Telephony.Models;
using Telephony.Models.Interfaces;

namespace Telephony.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IStationaryPhone stationaryPhone;
        private readonly ISmartphone smartphone;
        public Engine()
        {
            this.stationaryPhone = new StationaryPhone();
            this.smartphone = new Smartphone();
        }

        public Engine(IReader reader, IWriter writer) : this()
        {
            this.reader = reader;
            this.writer = writer;
        }


        public void Run()
        {
            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            foreach (var number in numbers)
            {
                try
                {
                    if (number.Length == 10)
                    {
                        this.writer.WriteLine(smartphone.Call(number));
                    }
                    else if (number.Length == 7)
                    {
                        this.writer.WriteLine(stationaryPhone.Call(number));
                    }
                    else
                    {
                        throw new InvalidPhoneNumberException();
                    }
                }
                catch (InvalidPhoneNumberException ipne)
                {
                    this.writer.WriteLine(ipne.Message);
                }
                catch (Exception)
                {
                    throw;
                }
            }

            foreach (var url in urls)
            {
                try
                {
                    writer.WriteLine(smartphone.BrowsingURL(url));
                }
                catch(InvalidURLException iue)
                {
                    writer.WriteLine(iue.Message);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
