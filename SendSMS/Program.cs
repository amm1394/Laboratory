using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Lab
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SendSMS.Classes.CheckSms Test = new SendSMS.Classes.CheckSms();
            Test.CheckInBox();
            Test.SendOutBox();

        }
    }
}
