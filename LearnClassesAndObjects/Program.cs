using LearnClassesAndObjects.Animals;
using LearnClassesAndObjects.Boxes;
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
            Box Pypa = new Box
            {
                Id = 5,
                Form = FormBox.Cube,
                Size = Size.Medium,
                Color = ColorBox.Red
            };

            Console.ReadKey();
        }


    }
}
