using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects
{
    class PersonFunction
    {
        static public string GetPerson(Person Name)
        {
            return $"{Name.LastName } {Name.FirstName} {Name.MiddleName} , {Name.Gender} , {Name.Age} years old, height - {Name.Height}cm";
        }
    }
}
