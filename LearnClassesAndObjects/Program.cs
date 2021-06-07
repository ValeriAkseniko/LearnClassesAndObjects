﻿using System;
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
            Person valera = new Person("Valera", "Akseniko", "Dmitrievich", "male", 24, 178, 60);
            Person aleksandr = new Person("Aleksandr", "Egorochkin", "Aleksandrovich", "male", 25, 182, 80);
            Person[] people = new Person[4];
            people[0] = anastasia;
            people[1] = artem;
            people[2] = valera;
            people[3] = aleksandr;
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(Person.GetPerson(people[i]));
            }
            int[] array = new int[4];
            Console.WriteLine();
            string TopH = PersonService.Highest(people);
            Console.WriteLine(TopH);
            Console.WriteLine();
            string TopL = PersonService.Lowest(people);
            Console.WriteLine(TopL);



            Console.ReadKey();




        }
        
    }
}
