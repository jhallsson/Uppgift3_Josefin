using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3_Josefin
{
    class PersonHandler
    {
        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            Person kalle = new Person();
            return kalle;
        }
        public void SetAge(Person pers, int age)
        {
            
            //ToDo: Instansera ny person? 

            //ToDo: Sätt pers Age till age
            pers.Age = age;
            Console.WriteLine("Handler: "+pers.Age);

        }
        
    }
}
