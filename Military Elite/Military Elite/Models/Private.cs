using Military_Elite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Models
{
    public class Private : Soldier, IPrivate
    {
        public decimal Salary { get; private set; }

        public Private(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName)
        {
            Salary = salary;
        }
        public override string ToString()
        {
            return base.ToString() + $" Salary: {this.Salary}";
        }
    }
}
