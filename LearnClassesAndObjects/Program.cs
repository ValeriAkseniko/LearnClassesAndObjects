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
            Product Cheese = new Product
            {
                Calories = 140.2,
                ID = Guid.NewGuid(),
                Name = "Chesse",
                Weight = 115.3,
                Price = 250.5m,
                CreationDate = DateTime.Now
            };
            Product Milk = new Product
            {
                Calories = 140.2,
                ID = Guid.NewGuid(),
                Name = "Milk",
                Weight = 1,
                Price = 78.5m,
                CreationDate = DateTime.Now
            };
            Product Sausage = new Product
            {
                Calories = 140.2,
                ID = Guid.NewGuid(),
                Name = "Sausage",
                Weight = 1.5,
                Price = 215m,
                CreationDate = DateTime.Now
            };
            List<Product> Products = new List<Product>();
            Products.Add(Cheese);
            Products.Add(Milk);
            Products.Add(Sausage);
            productService.SortByName(Products);
            productService.Print(Products);
            

            Console.ReadKey();
        }

    }
}
