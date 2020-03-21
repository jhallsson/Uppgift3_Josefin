using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3_Josefin
{
    class Bird : Animal
    {
        
        public double WingSpan { get; set; }

        public Bird(string name, double weight, int age, double wingSpan): base(name, weight, age)
        {
            WingSpan = wingSpan;
        }
        public override string Stats()
        {
            return $"{Name}, {Weight}, {Age}, {WingSpan}";
        }
    }
}
