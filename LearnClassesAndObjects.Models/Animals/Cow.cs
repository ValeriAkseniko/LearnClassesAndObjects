using LearnClassesAndObjects.ModelInterfaces;
using System;

namespace LearnClassesAndObjects.Models.Animals
{
    public class Cow : ISpeaker
    {
        public string Name { get; set; }
        public Cow()
        {
            Name = "Default name";
        }
        public Cow(string name)
        {
            Name = name;
        }
        public string GetSound()
        {
            return "Муу";
        }

        public void SaySound()
        {
            Console.WriteLine("Муу");
        }
    }
}
