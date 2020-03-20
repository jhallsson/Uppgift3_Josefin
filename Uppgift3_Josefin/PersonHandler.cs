using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3_Josefin
{
    class PersonHandler
    {
        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            Person person = new Person { 
                Age = age, 
                FirstName = fName, 
                LastName = lName, 
                Height = height, 
                Weight = weight 
            };
            return person;
        }
        public void SetAge(Person pers, int age)
        {
            
            //ToDo: Sätt pers Age till age
            pers.Age = age;
            Console.WriteLine("Handler: "+pers.Age);

        }
        //ToDo: SetHeight
        //ToDo: SetWeight
        //ToDo: SetName / lastName
    }
}
