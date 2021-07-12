using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects.Flat
{
    class FlatWithProperties
    {
        private Guid id;
        private int flatNumber;
        private double area;
        private string owner;
        private Enum flatType;
        public Guid Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int FlatNumber
        {
            get { return this.flatNumber; }
            set { this.flatNumber = value; }
        }
        public double Area
        {
            get { return this.area; }
            set { this.area = value; }
        }
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        public Enum FlatType
        {
            get { return this.flatType; }
            set { this.flatType = value; }
        }
        public string GetInfo()
        {
            return $"{id} ,{flatNumber}, {area}, {owner}, {flatType}";
        }

    }
}
