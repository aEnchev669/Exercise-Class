using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Exceptions;
using Telephony.Models.Interfaces;

namespace Telephony.Models
{
    public class Smartphone : ISmartphone
    {
        public string BrowsingURL(string url)
        {
            if (ValidUrl(url))
            {
                throw new InvalidURLException();
            }
            return $"Browsing: {url}!";
        }

        public string Call(string phoneNumber)
        {
            if (!ValidNumber(phoneNumber))
            {
                throw new InvalidPhoneNumberException();
            }
            return $"Calling... {phoneNumber}";
        }
        private bool ValidUrl(string url) => url.Any(ch => char.IsDigit(ch));
        private bool ValidNumber(string number) => number.All(ch => char.IsDigit(ch));
    }
}
