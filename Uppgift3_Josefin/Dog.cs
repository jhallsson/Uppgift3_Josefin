using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3_Josefin
{
    class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog(string name, double weight, int age, string breed) : base(name, weight, age)
        {
            Breed = breed;
        }
        public override string Stats()
        {
            return $"{base.Stats()} {Breed}";
        }
        public /*override*/ string Talk()
        {
            return "VOFF!";
        }
    }
}
