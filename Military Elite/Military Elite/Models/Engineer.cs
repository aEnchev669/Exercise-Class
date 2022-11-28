using Military_Elite.Models.Enums;
using Military_Elite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Models
{
    public class Engineer : Private, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {
        }

        public List<IRepair> Repairs { get; private set; }

        public Corps corps { get; private set; }
    }
}
