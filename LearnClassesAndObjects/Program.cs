using LearnClassesAndObjects.Animals;
using LearnClassesAndObjects.GlobalInterfaces;
using LearnClassesAndObjects.TypeProduct;
using Newtonsoft.Json;
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
        const string fileName = "listPerson.txt";
        static string path = $@"C:\Users\valer\Desktop\{fileName}";
        IPersonService personService;
        static ProductService productService = new ProductService();
        public Program(IPersonService personService)
        {
            this.personService = personService;
        }
        static void Main(string[] args)
        {
            Cow testcow = new Cow("Буренка");
            Dog testdog = new Dog();
            Cat testcat = new Cat();
            List<ISpeaker> speakers = new List<ISpeaker>();
            speakers.Add(testcat);
            speakers.Add(testdog);
            speakers.Add(testcow);

            for (int i = 0; i < speakers.Count; i++)
            {
                speakers[i].SaySound();
            }
            Cow Jyja = new Cow("Жужа");

            Jyja.SaySound();
            Console.ReadKey();
        }

    }
}
