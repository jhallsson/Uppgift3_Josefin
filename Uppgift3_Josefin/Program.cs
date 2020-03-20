using System;

namespace Uppgift3_Josefin
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonHandler persHand = new PersonHandler();

            //Person pers = new Person();
            //int age = 25;
            //persHand.SetAge(pers, age);

            Person kalle = persHand.CreatePerson(25, "Kalle", "Karlsson", 1.83, 79.2);
            Person lina = persHand.CreatePerson(36, "Lina", "Lund", 1.69, 65.30);
            
            Console.WriteLine($"{kalle.FirstName} {kalle.LastName}");
            Console.WriteLine($"{lina.FirstName} {lina.Age}");

        }
    }
}

