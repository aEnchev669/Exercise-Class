using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Models.Interfaces
{
    public interface IPrivate : ISoldier
    {
        decimal Salary { get; }
    }
}
