using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects.Flat
{
    class FlatWithAutoProperties
    {
        private Guid Id { get; set; }
        private int FlatNumber { get; set; }
        private double Area { get; set; }
        private string Owner { get; set; }
        private Enum FlatType { get; set; }
        public FlatWithAutoProperties()
        {

        }
        public FlatWithAutoProperties(Guid id,int flatNumber,double area,string owner,Enum flatType)
        {
            Id = id;
            FlatNumber = flatNumber;
            Area = area;
            Owner = owner;
            FlatType = flatType;
        }
        public string GetInfo()
        {
            return $"{Id} ,{FlatNumber}, {Area}, {Owner}, {FlatType}";
        }
    }
}
