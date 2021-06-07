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
        static public string GetPerson(Person Name)
        {
            return $"{Name.LastName } {Name.FirstName} {Name.MiddleName} , {Name.Gender} , {Name.Age} years old, height - {Name.Height}cm";
        }
        static public string GetFullName(Person Name)
        {
            return $"{Name.LastName} {Name.FirstName} {Name.MiddleName}";
        }
        static public string GetInitial(Person Name)
        {
            return $"{Name.LastName} {Name.FirstName[0]}.{Name.MiddleName[0]}.";
        }

    }
}
