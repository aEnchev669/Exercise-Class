using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
      private List<Person> persons;
        public List<Person> Persons { get => persons; set => persons = value; }
        public Family()
        {
            this.persons = new List<Person>();
        }
        public void AddMember(Person member)
        {
            this.persons.Add(member);
        }
        public Person GetOldestMember()
        {
            return this.persons
                .OrderByDescending(o => o.Age)
                .FirstOrDefault();
        }
    }
}
