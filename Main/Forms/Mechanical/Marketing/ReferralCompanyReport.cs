using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Marketing
{
    public partial class ReferralCompanyReport : RASF.General.Forms.Base.DockContentForm
    {
        public ReferralCompanyReport()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdcompany.ExportToExcel("شرکت های ارجاع داده شده");
        }

        private void ReferralCompanyReport_Load(object sender, EventArgs e)
        {
            this.referralCompanyReportList1.Fill();
            this.grdcompany.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.referralCompanyReportList1.Fill();
            this.grdcompany.Refetch();
        }
    }
}
