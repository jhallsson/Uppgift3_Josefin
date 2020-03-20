using System;

namespace Uppgift3_Josefin
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonHandler persHand = new PersonHandler();
            
            //ToDo: Instansera ny person?
            Person pers= new Person();
            
            int age = 25;
            persHand.SetAge(pers, age);
            

            Person kalle = persHand.CreatePerson(25, "Kalle","Karlsson",1.80,79.2);
            
            Console.WriteLine($"{kalle.FirstName} {kalle.LastName}");

        }
    }
}

