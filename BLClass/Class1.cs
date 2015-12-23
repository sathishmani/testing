using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BLClass
{
    public class Class1
    {

        public static int Timeout
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["Timeout"]); }
        }
    }

}

