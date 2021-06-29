using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects
{
    class Product
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }
        public decimal Price { get; set; }
        public DateTime CreationDate { get; set; }
        public Product()
        {

        }
        public Product(Guid ID, string Name, double Calories, decimal Price, DateTime CreationDate)
        {
            this.ID = ID;
            this.Name = Name;
            this.Calories = Calories;
            this.Price = Price;
            this.CreationDate = CreationDate;
        }
        public string GetInfo()
        {
            return $"{ID} , {Name} , {Calories} , {Price} , {CreationDate}";
        }
    }
}
