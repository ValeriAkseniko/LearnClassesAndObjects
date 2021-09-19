using System;

namespace LearnClassesAndObjects.Models.Products
{
    sealed class LiquidProduct : BaseProduct
    {
        const string Unit = "liters";
        public double Volume { get; set; }
        public LiquidProduct()
        {

        }
        public LiquidProduct(Guid ID, string Name, double Calories, decimal Price, double Volume, DateTime CreationDate)
            : base(ID, Name, Calories, Price, CreationDate)
        {
            this.Volume = Volume;
        }
        public override string GetInfo()
        {
            return $"{ID} , {Name} , {Calories} , {Volume} {Unit} , {Price} , {CreationDate}";
        }
    }
}
