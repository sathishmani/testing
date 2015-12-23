using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using NUnit.Framework;
using System.Configuration;

namespace PLINTRON.NUNIT.WEBSERVICE
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        [TestFixtureSetUp]
        public void Setup()
        {
            //ExtractResource("web.config", tempPath);
        }

        [Test]
        public void TestMethodPostive()
        {
            int i = 3;
            int j = 3;
            Assert.AreEqual(i, j);
        }

        [Test]
        [WebMethod]
        public void TestMethodWebConfig()
        {
            int i = 3;

            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
            fileMap.ExeConfigFilename = @"D:\Projects\PLINTRON.NUNIT\PLINTRON.NUNIT.WEBSERVICE\web.config";
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            

            int j = Convert.ToInt32(config.AppSettings.Settings["testWebConfig"].Value);
            //int j = Convert.ToInt32(System.Configuration.ConfigurationSettings.AppSettings["testWebConfig"]);
            Assert.AreEqual(i, j);
        }




    }
}