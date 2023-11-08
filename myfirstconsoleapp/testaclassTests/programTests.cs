using Microsoft.VisualStudio.TestTools.UnitTesting;
using testaclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testaclass;

namespace testaclass.Tests
{
    [TestClass()]
    public class programTests
    {
        [TestMethod()]
        public void additionTest()
        {
            int x = 12;
            int y = 23;
            int expectedvalue = x + y;
            int actualvalue=program.addition(x, y);
            Assert.AreEqual(expectedvalue, actualvalue);
        }
    }
}