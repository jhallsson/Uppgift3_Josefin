using System;

namespace Uppgift3_Josefin
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToDo: Instansera ny person?
            Person pers= new Person();
            int age = 25;

            PersonHandler persHand= new PersonHandler();
            
            //ToDo: Anropa SetAge(pers , age)
            persHand.SetAge(pers ,age );

            Console.WriteLine(pers.Age);
        }
    }
}
/*  
    
vart anropa metoden SetAge      Main eller inuti Person?
 
-Från main
-Du har precis innan skapat ett person objekt skicka med det och den nya åldern
Sätt åldern på personobjektet
titta före och efter att det är ändrat!

C# är pass by value
Men en referens typ håller bara adressen till det faktiska minnesplatsen för objektet
Det är den du skickar
Så ändras objektet i handlern
Så pekar den gammla variabeln på samma objekt

    
     * 
     
     1 Main: Deklarera ny Person kalle. Instansera. Sätt Kalle.Age - skicka till Person propertyt
 *  2 Person-property(?): Kalla på personHandler.SetAge - skicka med Person-värde (pers) och int-värde (age)
 *  
 *  1 Main: Deklarera ny Person kalle. Instansera. Sätt Kalle.Age - skicka till PersonHandler.SetAge?
 *  2 PersonHandler: SetAge skapar Person pers och sätter age-attributet till skickat Age property
     */
