using LearnClassesAndObjects.Models.Persons;
using System.Collections.Generic;

namespace LearnClassesAndObjects.ServiceInterfaces
{
    public interface IPersonService
    {
        int AverageAge(List<Person> listPerson);
        double AverageHeight(List<Person> listPerson);
        double AverageWeight(List<Person> listPerson);
        Person FirstOlder(Person[] array);
        Person FirstYoung(Person[] array);
        List<Person> GetFemaleList(List<Person> list);
        List<Person> GetMaleList(List<Person> list);
        Person Highest(Person[] array);
        Person Lowest(Person[] array);
        Person PersonFromConsole();
        void Print(List<Person> listPerson);
        List<Person> ReadFromTxt(string readPath);
        void SortByFullName(Person[] array);
        void SortByHighest(Person[] array);
        void WriteToTxt(string writePath, List<Person> listPersons);
        void WriteToTxt(string writePath, Person person, bool append);
        List<SimplePerson> ToSimplePersons(List<Person> persons);
    }
}
