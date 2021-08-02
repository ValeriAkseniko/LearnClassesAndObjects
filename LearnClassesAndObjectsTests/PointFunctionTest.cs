using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnClassesAndObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LearnClassesAndObjectsTests
{
    [TestClass()]
    public class PointFunctionTest
    {
        [TestMethod()]
        public void PlusTestNull()
        {
            PointFunction.Plus(null, null);
        } 
        
        [TestMethod()]
        public void MinuseTestNull()
        {
            PointFunction.Minuse(null, null);
        }
    }
}
