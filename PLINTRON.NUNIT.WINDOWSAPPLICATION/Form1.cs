using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PLINTRON.NUNIT.WINDOWSAPPLICATION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UsingSimpleStrings();
            //UsingStringBuilders();


            for (int i = 0; i < 10000; i++)
            {
                ClassGcTest gctest = new ClassGcTest();
            }
            lblMSG.Text = "Objects Crated! Now Close this window!!";
        }





        // Create a class    
        public class ClassGcTest : IDisposable
        {
            ~ClassGcTest()
            {
                //For unmanaged code    
            }


            public void Dispose()
            {

                GC.SuppressFinalize(true);

            }
        }

        private void UsingSimpleStrings()
        {
            string strSimpleStrings = "";
            for (int i = 0; i < 1000; i++)
            {
                strSimpleStrings = strSimpleStrings + "Test";
            }
        }


        private void UsingStringBuilders()
        {

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                strBuilder.Append("Test");
            }
        }
    }
}
