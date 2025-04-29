using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;


namespace MyNewService
{
    public partial class Sms_Service: ServiceBase
    {
        private System.Timers.Timer timer;
        private SendSMS.Classes.CheckSms CheckSms;
        public Sms_Service()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            CheckSms = new SendSMS.Classes.CheckSms();
            timer = new System.Timers.Timer();
            timer.Interval = 300000; // 5 Minutes
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }
        private void OnTimer(object sender, System.Timers.ElapsedEventArgs e)
        {
            timer.Enabled = false;
            try
            {
                CheckSms.SendOutBox();
                CheckSms.CheckInBox();
               
            }
            catch
            {
            }
            timer.Enabled = true;
        }

        protected override void OnStop()
        {
        }

        protected override void OnContinue()
        {
        }  
    }
}
