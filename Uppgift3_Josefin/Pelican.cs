using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3_Josefin
{
    class Pelican : Bird
    {
        public int FishCapacity { get; set; }
        public Pelican(string name, double weight, int age, double wingSpan, int fishCapacity) : base(name, weight, age, wingSpan) 
        {
            FishCapacity = fishCapacity;
        }
        public override string Stats()
        {
            return $"{Name}, {Weight}, {Age}, {WingSpan}, {FishCapacity}";
        }
    }
}
