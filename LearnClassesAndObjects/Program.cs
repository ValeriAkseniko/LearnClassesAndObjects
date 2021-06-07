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
            //Time timeOne = new Time(23,59,55);
            //while (true)
            //{
            //    Console.Clear();
            //    timeOne.addSecond(1);

            //    Console.WriteLine(timeOne.getTime());
            //    Thread.Sleep(1000);
            //}


            Person anastasia = new Person("Anastasia", "Malamanova", "Andreevna", "female", 23, 175, 60);
            Person artem = new Person("Artem", "Lipinski", "Dmitrievich", "male", 24, 170, 66);
            Person valera = new Person("Valera", "Akseniko", "Dmitrievich", "male", 24, 178,60);
            Person aleksandr = new Person("Aleksandr", "Egorochkin", "Aleksandrovich", "male", 25, 182,80);
            Console.WriteLine(Person.GetPerson(anastasia));
            Console.WriteLine();
            Console.WriteLine(Person.GetPerson(artem));
            Console.WriteLine();
            Console.WriteLine(Person.GetPerson(valera));
            Console.WriteLine();
            Console.WriteLine(Person.GetPerson(aleksandr));
            Console.WriteLine();
            Console.WriteLine(Person.GetFullName(anastasia));
            Console.WriteLine(Person.GetFullName(aleksandr));
            Console.WriteLine();
            Console.WriteLine(Person.GetInitial(valera));
            Console.WriteLine(Person.GetInitial(artem));
            Console.ReadKey();




        }
    }
}
