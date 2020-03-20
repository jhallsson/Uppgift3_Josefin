using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3_Josefin
{
    class PersonHandler
    {
        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            Person person = new Person(age,fName, lName,height,weight);
            /*,
                fName,
                lName,
                height,
                weight */
            /*Age = age, 
            FirstName = fName, 
            LastName = lName, 
            Height = height, 
            Weight = weight */

            return person;
        }
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }
        public void SetName(Person pers, string fName, string lName)
        {
            pers.FirstName = fName;
            pers.LastName = lName;
        }
        
    }
}
