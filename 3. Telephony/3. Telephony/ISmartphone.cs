using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface ISmartphone : IStationaryPhone
    {
        public void Browsing(string[] urls);
        public bool IsValid(string url);
    }
}
