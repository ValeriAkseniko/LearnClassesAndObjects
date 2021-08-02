using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnClassesAndObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnClassesAndObjects.GlobalInterfaces;

namespace LearnClassesAndObjects.Tests
{
    [TestClass()]
    public class PersonServiceTests
    {
        private readonly IPersonService personService;

        public PersonServiceTests()
        {
            this.personService = new PersonService();
        }


        [TestMethod()]
        public void PrintTest()
        {
            personService.Print(null);
        }

        [TestMethod()]
        public void SortByHighestTest()
        {
            personService.SortByHighest(null);
        }

        [TestMethod()]
        public void HighestTest()
        {
            personService.Highest(null);
        }

        [TestMethod()]
        public void LowestTest()
        {
            personService.Highest(null);
        }

        [TestMethod()]
        public void FirstOlderTest()
        {
            personService.FirstOlder(null);
        }

        [TestMethod()]
        public void FirstYoungTest()
        {
            personService.FirstYoung(null);
        }

        [TestMethod()]
        public void GetMaleListTest()
        {
            personService.GetMaleList(null);
        }

        [TestMethod()]
        public void GetFemaleListTest()
        {
            personService.GetFemaleList(null);
        }

        [TestMethod()]
        public void SortByFullNameTest()
        {
            personService.SortByFullName(null);
        }

        [TestMethod()]
        public void AverageHeightTest()
        {
            personService.AverageHeight(null);
        }

        [TestMethod()]
        public void AverageWeightTest()
        {
            personService.AverageWeight(null);
        }

        [TestMethod()]
        public void AverageAgeTest()
        {
            personService.AverageAge(null);
        }

        [TestMethod()]
        public void WriteToTxtTest()
        {
            personService.WriteToTxt(null, null);
        }

        [TestMethod()]
        public void ReadFromTxtTest()
        {
            personService.ReadFromTxt(null);
        }
    }
}