using LearnClassesAndObjects.ModelInterfaces;
using System;

namespace LearnClassesAndObjects.Models.Animals
{
    public class Cat : ISpeaker
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
