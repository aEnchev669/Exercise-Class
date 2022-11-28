using System;
using System.Collections.Generic;
using System.Text;
using Military_Elite.Models.Enums;

namespace Military_Elite.Models.Interfaces
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps corps { get; }
    }
}
