using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3_Josefin
{
    class Person
    {
        
        private string fName, lName;
        private int age;
        private double height, weight;
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
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        //ToDo: lägg till konstruktor
        public Person(int age, string fName, string lName, double height, double weight)
        {
            Age = age;
            FirstName = fName;
            LastName = lName;
            Height = height;
            Weight = weight;

        }
    }
}