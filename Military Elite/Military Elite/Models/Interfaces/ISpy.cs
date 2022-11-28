using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Models.Interfaces
{
    public interface ISpy : ISoldier
    {
        int CodeNumber { get; }
    }
}
