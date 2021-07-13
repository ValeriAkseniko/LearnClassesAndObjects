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
        static ProductService productService = new ProductService();
        static void Main(string[] args)
        {
            FlatWithAccessorMethods test = new FlatWithAccessorMethods();
            test.SetArea(46.5);
            test.SetFlatNumber(25);
            test.SetId(Guid.NewGuid());
            test.SetOwner("Vania Pechkin");
            test.SetFlatType(FlatType.Studio);
            Console.WriteLine(test.GetInfo());
            Console.WriteLine();
            FlatWithProperties test2 = new FlatWithProperties();
            test2.Area = 70.5;
            test2.FlatNumber = 13;
            test2.FlatType = FlatType.TwoRoom;
            test2.Owner = "Dmitri Sobkin";
            test2.Id = Guid.NewGuid();
            Console.WriteLine(test2.GetInfo());
            Console.WriteLine();
            FlatWithAutoProperties test3 = new FlatWithAutoProperties();
            test3.Area = 250.4;
            test3.FlatNumber = 18;
            test3.FlatType = FlatType.FourRoom;
            test3.Owner = "Vitali Volkov";
            test3.Id = Guid.NewGuid();
            Console.WriteLine(test3.GetInfo());
            Console.ReadKey();
        }


    }
}
