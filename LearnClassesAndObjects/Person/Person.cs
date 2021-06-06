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
        public Person(string firstName, string lastName, string middleName, string gender, int age, int height)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Gender = gender;
            Age = age;
            Height = height;
        }
        
    }
}
