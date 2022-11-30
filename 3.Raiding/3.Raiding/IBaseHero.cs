using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Raiding
{
    public interface IBaseHero
    {
        string Name { get; }
        int Power { get; }
        string CastAbility(string type, string name, int power);
    }
}
