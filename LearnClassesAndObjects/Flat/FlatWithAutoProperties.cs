using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects.Flat
{
    class FlatWithAutoProperties
    {
        public Guid Id { get; set; }
        public int FlatNumber { get; set; }
        public double Area { get; set; }
        public string Owner { get; set; }
        public FlatType FlatType { get; set; }
        
        public string GetInfo()
        {
            return $"{Id} ,{FlatNumber}, {Area}, {Owner}, {FlatType}";
        }
    }
}
