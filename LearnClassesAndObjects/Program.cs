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
        static PersonService personService = new PersonService();
        static ProductService productService = new ProductService();
        static void Main(string[] args)
        {
            Person popka = new Person
            {
                FirstName = "asd",
                LastName = "sad",
                MiddleName = "sad",
                Birthday = new DateTime(1996, 08, 14),
                Weight = 123,
                Height = 333,
                Id = 122,
                Gender = Gender.Man,
            };
            Person popka1 = new Person
            {
                FirstName = "aqwq",
                LastName = "sad",
                MiddleName = "sad",
                Birthday = new DateTime(1998, 08, 14),
                Weight = 123,
                Height = 12,
                Id = 122,
                Gender = Gender.Man,
            };
            List<Person> LOL = new List<Person>();
            LOL.Add(popka);
            LOL.Add(popka1);
            personService.WriteToTxt(path, LOL);
            LOL = personService.ReadFromTxt(path);
            personService.Print(LOL);
            Console.ReadKey();
        }

    }
}
