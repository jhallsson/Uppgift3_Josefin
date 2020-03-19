using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3_Josefin
{
    class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            
            //ToDo: Instansera ny person? 

            //ToDo: Sätt pers Age till age
            pers.Age = age;
            Console.WriteLine("Handler: "+pers.Age);

        }
        /*public void SetName(Person pers, string fName)
        {

            pers = new Person(fName);
            pers.FirstName = fName;
        }*/
    }
}
