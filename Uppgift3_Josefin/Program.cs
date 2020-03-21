using System;
using System.Collections.Generic;

namespace Uppgift3_Josefin
{
    // --- Svar på frågor finns längst ner! ---
    class Program
    {
        static void Main(string[] args)
        {
            //--- INKAPSLING ---

            PersonHandler persHand = new PersonHandler();

            //Person pers = new Person();
            //int age = 25;
            //persHand.SetAge(pers, age);

            Person kalle = persHand.CreatePerson(25, "Kalle", "Karlsson", 1.83, 79.2);
            Person lina = persHand.CreatePerson(36, "Lina", "Lund", 1.69, 65.30);
            
            Console.WriteLine($"Namn: {kalle.FirstName} {kalle.LastName}");
            Console.WriteLine($"Namn: {lina.FirstName} {lina.Age}\n");



            //--- ARV ANIMAL KLASS ---

            var horse = new Horse("Häst", 658, 10, 1.85);
            var bird = new Bird("Fågel", 2, 1, 0.8);

            //Bird pelican = new Bird("Pelican", 20, 3, 1.02);            //Bird is a Bird - Kommer inte åt pelican property (som en vanlig fågel som heter pelican)
            //Pelican pelican2 = new Pelican("Pelican", 20, 3, 1.02, 25); //Pelican is a Pelican
            //Pelican pelican4 = new Bird("Pelican", 20, 3, 1.02);        //Bird is not a Pelican?
            //Bird pelican3 = new Pelican("Pelican", 20, 3, 1.02,25);     //Pelican is a Bird - ska det vara typ Pelican måste FishCapcity anges

            Console.WriteLine($"{horse.WhitersHeight} m i mankhöjd" );
            Console.WriteLine($"{bird.Name} {bird.Age} år");

            
            //--- POLYMORFISM STATS METOD --- 

            Console.WriteLine($"Häst-objekts stats: {horse.Stats()}\n");

            List<Animal> Animals= new List<Animal>();
            List<Dog> Dogs = new List<Dog>();
            //Dogs.Add(new Horse("Pelikan", 30, 5, 1.5));

            Animals.Add(new Animal("Katt", 12, 5));
            Animals.Add(new Pelican("Pelikan", 30, 5, 1.5,30));
            Animals.Add(new Bird("Blåmes", 0.2, 1, 0.3));
            Animals.Add(new Dog("Hund",28,8,"Labrador"));

            foreach (var animal in Animals)
            {
                Console.WriteLine($"Stats för {animal.Name}: {animal.Stats()}");
            }

            //ToDo: loopa endast hundar
            /*foreach (Dog dog in Animals) 
            {
                Console.WriteLine("Stats för alla hundar i listan Animals");
                Console.WriteLine(dog.Stats());
                //Console.WriteLine(Dog.Talk());
                
            }*/
            Console.WriteLine();
            
            //--- UE-MESSAGES ---

            List<UserError> userErrors = new List<UserError>();
            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());
            userErrors.Add(new NullInputError());

            foreach (UserError error in userErrors)
            {
                Console.WriteLine(error.UEMessage());
            }
        }
    }
}

//Fråga 3.2.8: i klass Bird, för det gäller alla typer av fåglar men inte alla djur.
//Fråga 3.2.9: i klass Animal, för det gäller alla ärvda djur.
//Fråga 3.3.7: För att en häst är inte en hund. De ärver från samma klass Animals men inte från varandra.
//Fråga 3.3.8: Typ Animals, basklassen som alla har gemensam.
//Fråga 3.3.11: foreach loopar igenom alla objekt i listan Animals. Varje loopning anropar den varje nytt
//djurs metod Stats, alltså Animal.Stats(), Pelican.Stats() osv. Metoden returnerar en string med alla
//egenskaper för just det djuret (Name, Age, WingSpan, Breed etc.), och det skrivs ut i konsolen.
//Fråga 3.3.15: Talk() är inte ärvd från basklassen Animals som Stats() är. Då kan inte listobjekten av typ Animal
//nå den då den bara finns i subklassen Dog. 
//Fråga 3.4.11: Det är, tillsammans med inkapsling och arv, en viktig del av objektorienterad programmering.
//Polymorfism gör att man kan utgå från en basklass och sedan skapa specialvarianter av denna.
//Används det rätt ger det en tydlig struktur i koden. Man kan också råka ut för oväntade fel om man
//inte känner till och följer reglerna för polymorfism.
//Fråga 3.4.12: Man kan dela upp det på ett snyggt sätt, kan återanvända kod, och det blir lättare
//för andra att härleda i koden.
//Fråga 3.4.13: Abstrakt klass måste vara statisk, en subklass kan bara ärva från en klass. Interface är
//alltid publik, och en subklass kan använda sig av flera olika interface.

