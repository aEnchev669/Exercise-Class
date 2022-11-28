using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Models.Interfaces
{
    public interface ICommando : ISpecialisedSoldier
    {
        List<IMissions> Missions { get; }
    }
}
