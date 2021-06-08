using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public Person()
        {

        }
        public Person(string firstName, string lastName, string middleName, string gender, int age, int height, int weight)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Gender = gender;
            Age = age;
            Height = height;
            Weight = weight;
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
        


    }
}
