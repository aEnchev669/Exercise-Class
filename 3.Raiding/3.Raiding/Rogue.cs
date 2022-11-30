﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Raiding
{
    public class Rogue : BaseHero
    {
        public Rogue(string name, int power) : base(name, power)
        {
        }
        public override string CastAbility(string type, string name, int power)
        {
            return base.CastAbility(GetType().Name, name, power);
        }
        
    }
}
