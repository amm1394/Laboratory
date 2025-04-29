using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class NanoReport : RASF.General.Forms.Base.DockContentForm
    {
        public NanoReport()
        {
           
            InitializeComponent();
            this.nanoReportsList1.spName = "Nano";
            FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
            
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            FillGrid(e);
        }

        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.nanoReportsList1.Fill(Parameter);
            this.grdNano.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdNano.ExportToExcel("گزارش");
        }

    }
}
