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


            Person anastasia = new Person("Anastasia", "Malamanova", "Andreevna", "female", 23, 175);
            Person artem = new Person("Artem", "Lipinski", "Dmitrievich", "male", 24, 170);
            Person valera = new Person("Valera", "Akseniko", "Dmitrievich", "male", 24, 178);
            Person aleksandr = new Person("Aleksandr", "Egorochkin", "Aleksandrovich", "male", 25, 182);
            Console.WriteLine(PersonFunction.GetPerson(anastasia));
            Console.WriteLine();
            Console.WriteLine(PersonFunction.GetPerson(artem));
            Console.WriteLine();
            Console.WriteLine(PersonFunction.GetPerson(valera));
            Console.WriteLine();
            Console.WriteLine(PersonFunction.GetPerson(aleksandr));
            Console.WriteLine();
            Console.WriteLine(PersonFunction.GetFullName(anastasia));
            Console.WriteLine(PersonFunction.GetFullName(aleksandr));
            Console.WriteLine();
            Console.WriteLine(PersonFunction.GetInitial(valera));
            Console.WriteLine(PersonFunction.GetInitial(artem));
            Console.ReadKey();




        }
    }
}
