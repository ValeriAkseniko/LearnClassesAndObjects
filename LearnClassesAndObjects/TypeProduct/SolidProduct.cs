using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects.TypeProduct
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
