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
        static void Main(string[] args)
        {
            Product Sir = new Product
            {
                Calories = 140.2,
                ID = Guid.NewGuid(),
                Name = "Sir",
                Weight = 115.3,
                Price = 250.5m,
                CreationDate = DateTime.Now
            };
            Product Sir2 = new Product
            {
                Calories = 140.2,
                ID = Guid.NewGuid(),
                Name = "Sir",
                Weight = 115.3,
                Price = 250.5m,
                CreationDate = DateTime.Now
            };

            Sir = Sir2;
            Sir2.Price = 0.0m;


            Console.WriteLine(Sir.GetInfo());
            Console.ReadKey();
        }

    }
}
