﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age; 
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
    }
}
