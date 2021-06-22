using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects
{
    class PersonService
    {
        public void Print(List<Person> listPerson)
        {
            for (int i = 0; i < listPerson.Count; i++)
            {
                Console.WriteLine(listPerson[i].GetInfo());
            }
        }
        public void SortByHighest(Person[] array)
        {
            Person blank;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].Height > array[j].Height)
                    {
                        blank = array[i];
                        array[i] = array[j];
                        array[j] = blank;
                    }
                }
            }

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
            int indexMaxHighest = 0;
            double maxHighest = array[0].Height;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Height > maxHighest)
                {
                    maxHighest = array[i].Height;
                    indexMaxHighest = i;
                }
            }
            return array[indexMaxHighest];
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
            int indexMinHighest = 0;
            double minHighest = array[0].Height;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Height < minHighest)
                {
                    minHighest = array[i].Height;
                    indexMinHighest = i;
                }
            }
            return array[indexMinHighest];
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
            int indexOldest = 0;
            int oldest = array[0].Age;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Age > oldest)
                {
                    oldest = array[i].Age;
                    indexOldest = i;
                }
            }
            return array[indexOldest];
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
            int indexYoungest = 0;
            int youngest = array[0].Age;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Age < youngest)
                {
                    youngest = array[i].Age;
                    indexYoungest = i;
                }
            }
            return array[indexYoungest];
        }
        public List<Person> GetMaleList(Person[] array)
        {
            var listPerson = new List<Person>();
            if (array == null)
            {
                return null;
            }
            if (array.Length == 0)
            {
                return null;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Gender == Gender.Man)
                {
                    listPerson.Add(array[i]);
                }
            }
            return listPerson;
        }
        public List<Person> GetFemaleList(Person[] array)
        {
            var listPerson = new List<Person>();
            if (array == null)
            {
                return null;
            }
            if (array.Length == 0)
            {
                return null;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Gender == Gender.Woman)
                {
                    listPerson.Add(array[i]);
                }
            }
            return listPerson;
        }
        public void SortByFullName(Person[] array)
        {
            Person blank;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (string.Compare(array[i].GetFullName(), array[j].GetFullName()) > 0)
                    {
                        blank = array[i];
                        array[i] = array[j];
                        array[j] = blank;
                    }
                }
            }
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
            Console.Write("age: ");
            string age = Console.ReadLine();
            newPerson.Age = int.Parse(age);
            Console.Write("height: ");
            string height = Console.ReadLine();
            newPerson.Height = int.Parse(height);
            Console.Write("weight: ");
            string weight = Console.ReadLine();
            newPerson.Weight = int.Parse(weight);
            return newPerson;
        }
    }
}
