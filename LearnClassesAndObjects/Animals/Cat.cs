using LearnClassesAndObjects.GlobalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects.Animals
{
    public class Cat :ISpeaker
    {
        public bool HasEggs { get; set; }
        public string GetSound()
        {
            return "Мяу";
        }

        public void SaySound()
        {
            Console.WriteLine("Мяу");
        }
    }
}
