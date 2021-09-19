namespace LearnClassesAndObjects.Models.Products
{
    public sealed class SolidProduct : BaseProduct
    {
        const string Unit = "kilograms";
        public double Weight { get; set; }
        public override string GetInfo()
        {
            return $"{ID} , {Name} , {Calories} , {Weight} {Unit} , {Price} , {CreationDate}";
        }
    }
}
