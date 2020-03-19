using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3_Josefin
{
    class Person
    {
        private string fName, lName;
        private int age, height, weight;
        public string FirstName
        {
            get { return fName; }
            set { fName = value; }   
        }
        public string LastName
        {
            get { return lName; }
            set { lName = value; }
        }
        public int Age
        {
            get { return age; }
            set {age = value;   }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}