using Military_Elite.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Models.Interfaces
{
    public interface IMissions
    {
        string CodeName { get; }
        List<State> States { get; }
        void CompleteMission();
    }
}
