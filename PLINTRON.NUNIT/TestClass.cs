using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Collections;
using System.Threading;

namespace PLINTRON.NUNIT.CONSOLE
{
    [TestFixture]
    public class TestClass
    {

        [Test]
        public void TestMethodPostive()
        {
            int i = 3;
            int j = 3;
            Assert.AreEqual(i, j);
        }
        [Test]
        public void TestMethodAppConfig()
        {

            int i = 3;
            int j = Convert.ToInt32(System.Configuration.ConfigurationSettings.AppSettings["testAppConfig"]);

            Assert.AreEqual(i, j);
        }




        [Test, TestCaseSource("DivideCases")]
        public void DivideTest(int n, int d, int q)
        {
            Assert.AreEqual(q, n / d);
        }

        static object[] DivideCases =
            {
            new object[] { 12, 3, 4 },
            new object[] { 12, 2, 6 },
            new object[] { 12, 4, 3 } ,
             new object[] { 12, 3, 4 },
            new object[] { 12, 2, 6 },
            new object[] { 12, 4, 3 } 
            };

        static int[] EvenNumbers = new int[] { 2, 4, 6, 8 };

        [Test, TestCaseSource("EvenNumbers")]
        public void TestMethod(int num)
        {
            Assert.IsTrue(num % 2 == 0);
        }



        [TestCase(12, 3, ExpectedResult = 4)]
        [TestCase(12, 2, ExpectedResult = 6)]
        [TestCase(12, 4, ExpectedResult = 3)]
        public int DivideTest1(int n, int d)
        {
            Console.WriteLine((n / d));
            return (n / d);
        }



        [Test, Timeout(2000)]
        public void PotentiallyLongRunningTest()
        {
            Thread.Sleep(3000);
        }

    }


}
