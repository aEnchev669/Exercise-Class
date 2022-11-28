using Military_Elite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Models
{
    public class LeiutenantGeneral : Private, ILieutenantGeneral
    {
        public LeiutenantGeneral(int id, string firstName, string lastName, decimal salary, List<IPrivate> privates) : base(id, firstName, lastName, salary)
        {
            this.Privates = privates;
        }

        public List<IPrivate> Privates { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine( base.ToString())
                .AppendLine("Privates:");

            foreach (var item in Privates)
            {
                sb.AppendLine($"   {item.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
