using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3_Josefin
{
    class Person
    {
        private string fName;
        public string FirstName
        {
            get { return fName; }
            set { fName = value; }   //kalla på metod setName härifrån?
        }
        /* this.fName=setName
         */

        
    }
}

// private string fName, lName;
//private float age, height, weight;

//public string FirstName { get; set; }

/*public string LastName { get; set; }
    public int Height { get; set; }
    public int Age { get; set; }*/

/*public Person(string fName)
{
    //PersonHandler.SetName(person1, fName);
    this.fName = fName;
}*/
