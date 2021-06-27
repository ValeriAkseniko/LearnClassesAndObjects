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
            List<Person> listPersons = personService.ReadFromTxt(path);
            personService.Print(listPersons);

            personService.WriteToTxt(path, listPersons, true);
            Console.ReadKey();




        }
        
    }
}
