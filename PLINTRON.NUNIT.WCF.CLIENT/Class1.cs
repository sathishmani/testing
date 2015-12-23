using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace PLINTRON.NUNIT.WCF.CLIENT
{
    [TestFixture]
    public class Class1
    {


        [Test]
        public void testMethod()
        {
            PLINTRONWCFCLIENT.Service1Client objService1Client = new PLINTRONWCFCLIENT.Service1Client();
            
            objService1Client.GetData(1);
            int i = 3;
            int j = 4;
            Assert.AreEqual(i, j);
        }


    }
}
