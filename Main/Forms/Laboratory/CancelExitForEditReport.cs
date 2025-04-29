using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Laboratory
{
    public partial class CancelExitForEditReport : RASF.General.Forms.Base.DockContentForm
    {
        public CancelExitForEditReport()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
        }

        private void CancelExitForEditReport_Load(object sender, EventArgs e)
        {
            this.cancelExitForEditReportList1.Fill();
            this.grdReports.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.cancelExitForEditReportList1.Fill();
            this.grdReports.Refetch();
        }
    }
}
