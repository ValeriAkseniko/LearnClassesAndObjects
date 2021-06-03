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
            Time timeOne = new Time(23,59,50);
            while (true)
            {
                Console.Clear();
                timeOne.addSecond(1);

                Console.WriteLine(timeOne.getTime());
                Thread.Sleep(1000);
            }


            Console.ReadKey();
           
        }
    }
}
