using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class ReportMounthlyLaboratoryForm : RASF.General.Forms.Base.DockContentForm
    {
        public ReportMounthlyLaboratoryForm()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlSave = false;

        }

        private void ReportMounthlyLaboratoryForm_Load(object sender, EventArgs e)
        {
            this.reportMounthlyLaboratoryList1.Fill();
            this.grdReport.Refetch();

            this.monthlyReportList1.Fill();
            this.grdkol.Refetch();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.reportMounthlyLaboratoryList1.Fill();
            this.grdReport.Refetch();

            this.monthlyReportList1.Fill();
            this.grdkol.Refetch();
        }

        private void groupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
