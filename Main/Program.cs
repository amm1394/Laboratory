using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fa-IR");

            System.Timers.Timer timer = new System.Timers.Timer(600000); // 600,000 میلی‌ثانیه = 10 دقیقه

            //// تنظیم رویداد تایمر
            //timer.Elapsed += OnTimedEvent;
            //timer.AutoReset = true; // برای تکرار به صورت خودکار
            //timer.Enabled = true;

            //string str = Application.ExecutablePath.ToUpper();
            //if ((str.CompareTo(@"\\192.168.0.17\RELEASE\MAIN.EXE") != 0))
            //{
            //    MessageBox.Show("لطفا از مسير اصلي اجرا نماييد.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}
            //else
            //{
            //RASF.General.Lists.Csv_ContractList Csv_ContractList = new RASF.General.Lists.Csv_ContractList();
            //Csv_ContractList.Fill();
            RASF.Main.Forms.Settings.LoginForm LoginForm = new RASF.Main.Forms.Settings.LoginForm();

            if (LoginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new RASF.Main.Forms.NewMainForm());
                // Application.Run(new RASF.Main.Forms.SEM.Form1());
            }
        }

        private static void OnTimedEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers(); // برای اطمینان از اجرای کامل عملیات
        }
    }
}
//}

