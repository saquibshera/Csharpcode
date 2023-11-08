using Microsoft.VisualStudio.TestTools.UnitTesting;
using testmylib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testmylib;

namespace testmylib.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void addTest()
        {
            Class1 obj = new Class1();
            int x = 23;
            int y = 34;
            int expected = x + y;
            int actualvalue=obj.add(x,y);
            Assert.AreEqual(expected,actualvalue);
        }
    }
}