using LearnClassesAndObjects.ModelInterfaces;
using System;

namespace LearnClassesAndObjects.Models.Animals
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
