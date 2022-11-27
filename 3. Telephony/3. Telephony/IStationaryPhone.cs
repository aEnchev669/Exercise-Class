using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface IStationaryPhone
    {
        public void Calling(string number);
        public bool IsValidNumber(string number);
    }
}
