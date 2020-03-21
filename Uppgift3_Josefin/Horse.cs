using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3_Josefin
{
    class Horse : Animal
    {

        public double WhitersHeight { get; set; }
        public Horse(string name, double weight, int age, double withersHeight) : base(name, weight, age)
        {
            WhitersHeight = withersHeight;
        }
        public override string Stats()
        {
            return $"{Name}, {Weight}, {Age}, {WhitersHeight}";
        }
    }
}
