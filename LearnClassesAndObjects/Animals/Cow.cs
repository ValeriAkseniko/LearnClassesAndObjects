using LearnClassesAndObjects.GlobalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects.Animals
{
    public class Cow : ISpeaker
    {
        public string Name { get; set; }
        public Cow()
        {
            this.Name = "Default name";
        }
        public Cow(string name)
        {
            this.Name = name;
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
