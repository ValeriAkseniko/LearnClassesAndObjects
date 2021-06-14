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


            Person anastasia = new Person("Anastasia", "Malamanova", "Andreevna", Gender.Woman, 23, 175, 60);
            Person artem = new Person("Artem","Lipinski","Dmitrievich", Gender.Man, 24, 170, 66);
            Person valera = new Person("Valera", "Akseniko", "Dmitrievich", Gender.Man, 24, 178, 60);
            Person aleksandr = new Person("Aleksandr", "Egorochkin","Aleksandrovich", Gender.Man, 25, 182, 80);
            Person nika = new Person("Veronika", "Egorochkina", "Dmitrievna", Gender.Woman, 22, 165, 50);
            Person[] people = new Person[5];
            people[0] = anastasia;
            people[1] = artem;
            people[2] = valera;
            people[3] = aleksandr;
            people[4] = nika;
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i].GetInfo());
            }
            int[] array = new int[4];
            Console.WriteLine();
           
            



            Console.ReadKey();




        }
        
    }
}
