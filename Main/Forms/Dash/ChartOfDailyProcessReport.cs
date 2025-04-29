using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Dash
{
    public partial class ChartOfDailyProcessReport : RASF.General.Forms.Base.DockContentForm
    {
        public ChartOfDailyProcessReport()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
            
        }
        private DateTime From, To;

            
        private void Laboratory_Load(object sender, EventArgs e)
        {
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
            dashboardViewer1.BeginUpdateParameters();
            dashboardViewer1.Parameters["From"].SelectedValue = DateTime.Now;
            dashboardViewer1.Parameters["To"].SelectedValue = DateTime.Now;
            dashboardViewer1.EndUpdateParameters();

            

        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            this.From = e.From;
            this.To = e.To;
            dashboardViewer1.BeginUpdateParameters();
            dashboardViewer1.Parameters["From"].SelectedValue = From;
            dashboardViewer1.Parameters["To"].SelectedValue = To;
            dashboardViewer1.EndUpdateParameters();
         
        }

    }
}
