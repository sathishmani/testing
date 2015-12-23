using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

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

       


    }
}
