using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Web;
using PLINTRON.NUNIT.WEBAPPLICATION;
namespace PLINTRON.NUNIT.TESTCASE
{
    public class NUnitTets
    {
        [TestCase("Check")]
        public void TestMethodAppConfig(string test)
        {
            WebForm1 objWebForm1 = new WebForm1();
            Assert.AreEqual("3",objWebForm1.getIP(test));
         }


        [TestCase("1234567890", 10)]
        [TestCase("9", "9")]
        [TestCase("12345678901", 11)]
        [Category("Low")]
        [Category("Medium")]
        [Category("High")]
        [Category("Complete")]
        public void GBA_ValidPoolNumberLength(string poolNumber, string length)
        {

            Assert.AreEqual(poolNumber, length);
        }
    }
}
