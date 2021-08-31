using LearnClassesAndObjects.GlobalInterfaces;
using LearnClassesAndObjects.Persons;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LearnClassesAndObjects
{
    public class PersonService : IPersonService
    {
        public void Print(List<Person> listPerson)
        {
            if (listPerson == null)
            {
                return;
            }
            for (int i = 0; i < listPerson.Count; i++)
            {
                Console.WriteLine(listPerson[i].GetInfo());
            }
        }
        public void SortByHighest(Person[] array)
        {
            if (array == null)
            {
                return;
            }
            var sortByHighest = array.OrderBy(h => h.Height);

        }
        public Person Highest(Person[] array)
        {
            if (array == null)
            {
                return null;
            }
            if (array.Length == 0)
            {
                return null;
            }
            var maxHeight = array.Max(h => h.Height);
            var heighest = array.FirstOrDefault(h => h.Height == maxHeight);
            return heighest;
        }
        public Person Lowest(Person[] array)
        {
            if (array == null)
            {
                return null;
            }
            if (array.Length == 0)
            {
                return null;
            }
            var minHeight = array.Min(h => h.Height);
            var lowest = array.FirstOrDefault(h => h.Height == minHeight);
            return lowest;
        }
        public Person FirstOlder(Person[] array)
        {
            if (array == null)
            {
                return null;
            }
            if (array.Length == 0)
            {
                return null;
            }
            var maxAge = array.Max(a => a.Age);
            var older = array.FirstOrDefault(a => a.Age == maxAge);
            return older;
        }
        public Person FirstYoung(Person[] array)
        {
            if (array == null)
            {
                return null;
            }
            if (array.Length == 0)
            {
                return null;
            }
            var minAge = array.Min(a => a.Age);
            var young = array.FirstOrDefault(a => a.Age == minAge);
            return young;
        }
        public List<Person> GetMaleList(List<Person> list)
        {            
            if (list == null)
            {
                return null;
            }
            if (list.Count == 0)
            {
                return null;
            }
            var malePersons = list.Where(m => m.Gender == Gender.Man).ToList();
            return malePersons;
        }
        public List<Person> GetFemaleList(List<Person> list)
        {
            var listPerson = new List<Person>();
            if (list == null)
            {
                return null;
            }
            if (list.Count == 0)
            {
                return null;
            }
            var femalePerson = list.Where(f => f.Gender == Gender.Woman).ToList();
            return femalePerson;
        }
        public void SortByFullName(Person[] array)
        {
            if (array == null)
            {
                return;
            }
            var sortByFullName = array.OrderBy(n => n.GetFullName());
        }
        public double AverageHeight(List<Person> listPerson)
        {
            if (listPerson != null)
            {
                double average = 0;
                for (int i = 0; i < listPerson.Count; i++)
                {
                    average = average + listPerson[i].Height;
                }
                average = average / listPerson.Count;
                return average;
            }
            else
            {
                return 0;
            }

        }
        public double AverageWeight(List<Person> listPerson)
        {
            if (listPerson != null)
            {
                double average = 0;
                for (int i = 0; i < listPerson.Count; i++)
                {
                    average = average + listPerson[i].Weight;
                }
                average = average / listPerson.Count;
                return average;
            }
            else
            {
                return 0;
            }

        }
        public int AverageAge(List<Person> listPerson)
        {
            if (listPerson != null)
            {
                int average = 0;
                for (int i = 0; i < listPerson.Count; i++)
                {
                    average = average + listPerson[i].Age;
                }
                average = average / listPerson.Count;
                return average;
            }
            else
            {
                return 0;
            }

        }
        public Person PersonFromConsole()
        {
            Person newPerson = new Person();
            Console.Write("first name: ");
            newPerson.FirstName = Console.ReadLine();
            Console.Write("last name: ");
            newPerson.LastName = Console.ReadLine();
            Console.Write("middle name: ");
            newPerson.MiddleName = Console.ReadLine();
            Console.Write("0 for woman, 1 for man: ");
            int intGender = int.Parse(Console.ReadLine());
            newPerson.Gender = (Gender)intGender;
            Console.Write("birthday: ");
            string birthday = Console.ReadLine();
            newPerson.Birthday = DateTime.Parse(birthday);
            Console.Write("height: ");
            string height = Console.ReadLine();
            newPerson.Height = int.Parse(height);
            Console.Write("weight: ");
            string weight = Console.ReadLine();
            newPerson.Weight = int.Parse(weight);
            return newPerson;
        }
        public void WriteToTxt(string writePath, Person person, bool append)
        {

            using (StreamWriter streamWriter = new StreamWriter(writePath, append, Encoding.Default))
            {
                streamWriter.WriteLine(person.InfoForWrite());
            }
        }
        public void WriteToTxt(string writePath, List<Person> listPersons)
        {
            if (listPersons == null || writePath == null)
            {
                return;
            }
            string json = ConvertToJson(listPersons);
            using (StreamWriter streamWriter = new StreamWriter(writePath, false, Encoding.Default))
            {
                streamWriter.Write(json);
            }
        }
        public List<Person> ReadFromTxt(string readPath)
        {
            if (readPath == null)
            {
                return null;
            }
            using (StreamReader streamReader = new StreamReader(readPath))
            {
                List<Person> persons = new List<Person>();
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    persons = ConvertFromJson(line);
                }
                return persons;
            }
        }
        private string ConvertToJson(List<Person> listPerson)
        {
            string json = JsonConvert.SerializeObject(listPerson);
            return json;
        }
        private List<Person> ConvertFromJson(string strJson)
        {
            List<Person> person = JsonConvert.DeserializeObject<List<Person>>(strJson);
            return person;
        }

        public List<SimplePerson> ToSimplePersons(List<Person> persons)
        {
            var simplePersons = persons.Select(p => new SimplePerson
            {
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                MIddleName = p.MiddleName
            }).ToList();
            return simplePersons;
        }
    }
}
