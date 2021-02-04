using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using up_5_lib;
using System.Collections.Generic;


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = new int[] { 8, 1, -4};
            Massive.Sorty(a);
            Assert.AreEqual(a[0], -4);
            Assert.AreEqual(a[1], 1);
            Assert.AreEqual(a[2], 8);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Cowotainer cowo1 = new Cowotainer();
            cowo1.Add(3);
            cowo1.Add(4);
            cowo1.Add(5);
            Cowotainer cowo2 = new Cowotainer();
            cowo2.Add(3);
            cowo2.Add(4);
            cowo2.Add(5);
            Cowotainer cowo3 = new Cowotainer();
            cowo3.Add(9);
            cowo3.Add(16);
            cowo3.Add(25);
            Assert.AreEqual(cowo3[0], (cowo1*cowo2)[0]);
            Assert.AreEqual(cowo3[1], (cowo1*cowo2)[1]);
            Assert.AreEqual(cowo3[2], (cowo1*cowo2)[2]);

        }

        [TestMethod]
        public void TestMethod3()
        {
            List<int> list = new List<int>() { 2, 5, 7, 3 };
            Cowotainer cowo1 = new Cowotainer(list);
            Assert.AreEqual(7, cowo1[2]);
        }
    }
}
