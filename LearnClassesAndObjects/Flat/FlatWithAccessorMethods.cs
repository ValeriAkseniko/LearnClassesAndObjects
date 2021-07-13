using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects.Flat
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
            return this.id;
        }
        public void SetId(Guid newId)
        {
            id = newId;
        }
        public int GetFlatNumber()
        {
            return this.flatNumber;
        }
        public void SetFlatNumber(int newFlatNumber)
        {
            flatNumber = newFlatNumber;
        }
        public double GetArea()
        {
            return this.area;
        }
        public void SetArea(double newArea)
        {
            area = newArea;
        }
        public string GetOwner()
        {
            return this.owner;
        }
        public void SetOwner(string newOwner)
        {
            owner = newOwner;
        }
        public FlatType GetFlatType()
        {
            return this.flatType;
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
