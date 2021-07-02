using LearnClassesAndObjects.GlobalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects.Animals
{
    public class Dog : ISpeaker
    {
        public string Color { get; set; }
        public string GetSound()
        {
            return "Гав";
        }

        public void SaySound()
        {
            Console.WriteLine("Гав");
        }
    }
}
