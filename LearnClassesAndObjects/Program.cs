using LearnClassesAndObjects.Animals;
using LearnClassesAndObjects.Flat;
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
        static void Main(string[] args)
        {
            FlatWithAccessorMethods test = new FlatWithAccessorMethods();
            test.SetArea(46.5);
            test.SetFlatNumber(228);
            test.SetId(Guid.NewGuid());
            test.SetOwner("Sakaka Pypkin");
            test.SetFlatType(EnumFlatType.Studio);
            Console.WriteLine(test.GetInfo());
            Console.WriteLine();
            FlatWithProperties test2 = new FlatWithProperties();
            test2.Area = 70.5;
            test2.FlatNumber = 420;
            test2.FlatType = EnumFlatType.TwoRoom;
            test2.Owner = "Policai Jopa";
            test2.Id = Guid.NewGuid();
            Console.WriteLine(test2.GetInfo());
            Console.WriteLine();
            FlatWithAutoProperties test3 = new FlatWithAutoProperties(Guid.NewGuid(),52,350.3,"Sin Sobaki",EnumFlatType.FourRoom) ;
            Console.WriteLine(test3.GetInfo());
            Console.ReadKey();
        }


    }
}
