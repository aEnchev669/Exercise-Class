using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Exceptions;
using Telephony.Models.Interfaces;

namespace Telephony.Models
{
    public class StationaryPhone : IStationaryPhone
    {
        public string Call(string phoneNumber)
        {
            if (!ValidNumber(phoneNumber))
            {
                throw new InvalidPhoneNumberException();
            }
            return $"Dialing... {phoneNumber}";
        }
        private bool ValidNumber(string number) => number.All(ch => char.IsDigit(ch));
    }
}
