using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            private set 
            {
                if (value < 650)
                {
                    throw new ArgumentException("Salary cannot be less than 650 leva!");
                }
                salary = value;
            }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            private set 
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                firstName = value; 
            }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                lastName = value;
            }
        }

        private int age;

        public int Age
        {
            get { return age; }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                age = value; 
            }
        }
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }
        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age < 30)
            {
                Salary += Salary * (percentage / 2 / 100);
            }
            else
            {
                Salary += Salary * (percentage / 100);
            }
        }

        public override string ToString()
        {
            return ($"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.");
        }
    }
}
