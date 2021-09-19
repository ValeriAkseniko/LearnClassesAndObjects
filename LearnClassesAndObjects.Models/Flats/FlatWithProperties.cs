using System;

namespace LearnClassesAndObjects.Models.Flats
{
    class FlatWithProperties
    {
        private Guid id;
        private int flatNumber;
        private double area;
        private string owner;
        private FlatType flatType;
        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }
        public int FlatNumber
        {
            get { return flatNumber; }
            set { flatNumber = value; }
        }
        public double Area
        {
            get { return area; }
            set { area = value; }
        }
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public FlatType FlatType
        {
            get { return flatType; }
            set { flatType = value; }
        }
        public string GetInfo()
        {
            return $"{id} ,{flatNumber}, {area}, {owner}, {flatType}";
        }

    }
}
