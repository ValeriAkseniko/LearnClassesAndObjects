using LearnClassesAndObjects.TypeProduct;
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
            BaseProduct BubbleGum = new BaseProduct
            {
                Calories = 140.2,
                ID = Guid.NewGuid(),
                Name = "Orbit",
                Price = 30m,
                CreationDate = DateTime.Now
            };
            LiquidProduct Milk = new LiquidProduct
            {
                Calories = 67.2,
                ID = Guid.NewGuid(),
                Name = "Milk",
                Price = 78.5m,
                Volume = 1,
                CreationDate = DateTime.Now
            };
            SolidProduct Sausage = new SolidProduct
            {
                Calories = 200.2,
                ID = Guid.NewGuid(),
                Name = "Sausage",
                Price = 215m,
                Weight = 0.2,
                CreationDate = DateTime.Now
            };
            LiquidProduct Water = new LiquidProduct
            {
                Calories = 10,
                ID = Guid.NewGuid(),
                Name = "Voljanka",
                Price = 45m,
                Volume = 0.5,
                CreationDate = DateTime.Now
            };
            SolidProduct Potato = new SolidProduct
            {
                Calories = 125,
                ID = Guid.NewGuid(),
                Name = "Belorus potato",
                Price = 70m,
                Weight = 1,
                CreationDate = DateTime.Now
            };            
            List<BaseProduct> Products = new List<BaseProduct>();
            Products.Add(BubbleGum);
            Products.Add(Milk);
            Products.Add(Sausage);
            Products.Add(Water);
            Products.Add(Potato);
            List<SolidProduct> solidProducts = new List<SolidProduct>() {Sausage,Potato };
            productService.Print(Products);


            Console.ReadKey();
        }

    }
}
