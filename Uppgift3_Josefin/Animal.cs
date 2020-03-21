﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3_Josefin
{
    class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }
        public virtual string Stats()
        {
            return $"{Name}, {Weight}, {Age}";
        }
        public virtual string Talk() //ToDo: Finns det ett annat sätt att komma åt Talk()? 
        {
            return "Animal.Talk() (overrided)";
        }
    }
}
