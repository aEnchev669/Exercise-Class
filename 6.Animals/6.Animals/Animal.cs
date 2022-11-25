
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Invalid Input!");
                name = value;
            }
        }
        private int age;

        public int Age
        {
            get { return age; }
            private set
            {
                if (value <= 0) throw new ArgumentException("Invalid Input!");
                age = value;
            }
        }
        private string gender;

        public string Gender
        {
            get { return gender; }
            set
            {
                if (value != "Male" && value != "Female") throw new ArgumentException("Invalid Input!");
                gender = value;
            }
        }


        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public virtual string ProduceSound() => "Noise";

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(GetType().Name)
                .AppendLine($"{this.Name} {this.Age} {this.Gender}")
                .AppendLine(ProduceSound());

            return sb.ToString();
        }

    }
}
