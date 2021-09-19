using System;

namespace LearnClassesAndObjects.Models.Flats
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
