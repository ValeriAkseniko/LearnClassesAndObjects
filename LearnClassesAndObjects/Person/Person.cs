using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects
{
    class Person
    {
        private int age;
        private double height;
        private double weight;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (IsValid(value))
                {
                    age = value;
                }
            }
        }
        public string Email { get; set; }
        
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (IsValid(value))
                {
                    height = value;
                }
            }
        }
        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (IsValid(value))
                {
                    weight = value;
                }
            }
        }
        public Person()
        {

        }
        public Person(string firstName, string lastName, string middleName, string gender, int age, double height, double weight, string email = null)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Gender = gender;
            if (IsValid(age))
            {
                this.Age = age;
            }
            else
            {
                this.Age = 0;
            }
            if (IsValid(height))
            {
                this.Height = height;
            }
            else
            {
                this.Height = 0;
            }
            if (IsValid(weight))
            {
                this.Weight = weight;
            }
            else
            {
                this.Weight = 0;
            }
            Email = email;
        }
        public string GetInfo()
        {
            return $"{LastName } {FirstName} {MiddleName} , {Gender} , {Age} years old, height - {Height}cm, weight - {Weight}";
        }
        public string GetFullName()
        {
            return $"{LastName} {FirstName} {MiddleName}";
        }
        public string GetInitial()
        {
            return $"{LastName} {FirstName[0]}.{MiddleName[0]}.";
        }
        public bool IsValid(int age)
        {
            return age > 0;
        }
        public bool IsValid(double heightOrWeight)
        {
            return heightOrWeight > 0;
        }




    }
}
