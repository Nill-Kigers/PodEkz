using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void MinAVGTest()
        {
            string[] pass = { "1", "2" };
            double expected = 1.5;
            double actual = Class1.MinAVG(pass);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void LetterAndNum()
        {
            string[] pass = { "f", "2" };
            double expected = 1;
            double actual = Class1.MinAVG(pass);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Div0()
        {
            string[] pass = {};
            double expected = 0;
            double actual = Class1.MinAVG(pass);

            Assert.AreEqual(expected, actual);
        }
    }
}