using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using BLClass;


namespace PLINTRON.NUNIT.WEBAPPLICATION
{
    public partial class WebForm1 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string getIP(string set)
        {
            string IPAddress = "";
            try
            {
                IPAddress = (ConfigurationManager.AppSettings["testAppConfig"].ToString());
              
            }
            catch (Exception ex)
            {
                throw ex;

            }

            return IPAddress;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Write("Success");
        }


    }
}