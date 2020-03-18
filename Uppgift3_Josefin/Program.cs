using System;

namespace Uppgift3_Josefin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person("Kalle");
            //person1.FirstName = "Kalle";
            
            PersonHandler personHandler = new PersonHandler();
            personHandler.SetName(kalle, "Kalle"); //måste deklarera Person men vill göra det i SetName

            Console.WriteLine(); 
        }
    }
}
