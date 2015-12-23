using System;
using System.Threading;
using System.ServiceProcess;

using System.Xml;

namespace AutoTopupService
{
    partial class TopupService : ServiceBase
    {
        


        public TopupService()
        {
            InitializeComponent();
            DoAutoTopup();
            //sendMaxlimitEmail();
        }
        protected override void OnStart(string[] args)
        {
           
            createThreads();
            //Thread.Sleep(30 * 1000);
        }
        public void createThreads()
        {
            try
            {
                //int threadCount = Convert.ToInt32(ConfigurationManager.AppSettings["NoOfThread"]);
                int threadCount = 1;
                for (int i = 0; i < threadCount; i++)
                    new Thread(startProcessing).Start();
            }
            catch (Exception ex)
            {
               
            }
        }
        public void startProcessing()
        {
          
            while (true)
            {
                try
                {
                    Thread.Sleep(30 * 1000);
                    DoAutoTopup();
                }
                catch (Exception ex)
                {
                    
                }
            }
        }
        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service
            //timer12.Stop();
            
        }
        private void DoAutoTopup()
        {
            XmlDocument xmlBaldoc = new XmlDocument();

            
     
       
            int successTime = Convert.ToInt32(10);
            try
            {
                Console.Write("sss");

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                //timer12.Interval = 1000;
            }
        }




    }
}
