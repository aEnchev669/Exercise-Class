using Military_Elite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Models
{
    public class Spy : Soldier,ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNumber) : base(id, firstName, lastName)
        {
            this.CodeNumber = CodeNumber;
        }

        public int CodeNumber { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{base.ToString()}")
                .AppendLine($"Code Number: {CodeNumber}");

            return sb.ToString();
        }
    }
}
