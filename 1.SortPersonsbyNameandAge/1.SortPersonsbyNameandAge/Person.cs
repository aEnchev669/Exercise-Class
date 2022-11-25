using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
           private set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            private set { lastName = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString()
        {
            return ($"{this.FirstName} {this.LastName} is {this.Age} years old.");
        }
    }
}
