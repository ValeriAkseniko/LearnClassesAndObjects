using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearnClassesAndObjects
{
    class Program
    {

        static void Main(string[] args)
        {            
            Person anastasia = new Person(1, "Anastasia", "Malamanova", "Andreevna", Gender.Woman, 23, 175, 60);
            Person artem = new Person(2, "Artem","Lipinski","Dmitrievich", Gender.Man, 24, 170, 66);
            Person valera = new Person(3, "Valera", "Akseniko", "Dmitrievich", Gender.Man, 24, 178, 60);
            Person aleksandr = new Person(4, "Aleksandr", "Egorochkin","Aleksandrovich", Gender.Man, 25, 182, 80);
            Person nika = new Person(5, "Veronika", "Egorochkina", "Dmitrievna", Gender.Woman, 22, 165, 50);
            var listPerson = new List<Person>
            {
                anastasia,
                artem,
                valera,
                aleksandr,
                nika
            };
            PersonService personService = new PersonService();
            personService.Print(listPerson);
            Person newPerson = personService.PersonFromConsole();
            listPerson.Add(newPerson);
            personService.Print(listPerson);
            Console.WriteLine();
            Console.WriteLine(personService.AverageHeight(listPerson));
            Console.WriteLine(personService.AverageWeight(listPerson));
            Console.WriteLine(personService.AverageAge(listPerson));





            Console.ReadKey();




        }
        
    }
}
