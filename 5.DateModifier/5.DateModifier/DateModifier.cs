using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        private DateTime firstDate;
        private DateTime secondDate;

        public DateTime FirstDate { get => firstDate; set => firstDate = value; }
        public DateTime SecondDate { get => secondDate; set => secondDate = value; }
        public DateModifier(string date1, string date2)
        {
            this.FirstDate = DateTime.Parse(date1);
            this.SecondDate = DateTime.Parse(date2);
        }
        public void Difference()
        {
            int difference = (SecondDate.Date - firstDate.Date).Days;
            Console.WriteLine(Math.Abs(difference)); 
        }
    }
}
