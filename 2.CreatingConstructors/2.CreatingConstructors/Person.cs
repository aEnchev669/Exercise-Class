using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {

        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }
        public Person(int age)
        {
            this.name = "No name";
            this.age = age;
        }
        public Person(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }
        private string name;
        private int age;
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
    }
}
