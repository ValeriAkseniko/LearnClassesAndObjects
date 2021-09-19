using System;

namespace LearnClassesAndObjects.Models.Flats
{
    class FlatWithAccessorMethods
    {
        private Guid id;
        private int flatNumber;
        private double area;
        private string owner;
        private FlatType flatType;


        public Guid GetId()
        {
            return id;
        }
        public void SetId(Guid newId)
        {
            id = newId;
        }
        public int GetFlatNumber()
        {
            return flatNumber;
        }
        public void SetFlatNumber(int newFlatNumber)
        {
            flatNumber = newFlatNumber;
        }
        public double GetArea()
        {
            return area;
        }
        public void SetArea(double newArea)
        {
            area = newArea;
        }
        public string GetOwner()
        {
            return owner;
        }
        public void SetOwner(string newOwner)
        {
            owner = newOwner;
        }
        public FlatType GetFlatType()
        {
            return flatType;
        }
        public void SetFlatType(FlatType newFlatType)
        {
            flatType = newFlatType;
        }
        public string GetInfo()
        {
            return $"{id} ,{flatNumber}, {area}, {owner}, {flatType}";
        }

    }
}
