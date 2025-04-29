using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class ReportMounthlyLaboratory2017To2018KolForm : RASF.General.Forms.Base.DockContentForm
    {
        public ReportMounthlyLaboratory2017To2018KolForm()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlSave = false;

        }

        private void ReportMounthlyLaboratoryForm_Load(object sender, EventArgs e)
        {
          //  this.reportMounthlyLaboratory2017To2018List1.Fill();
            this.grdReport.Refetch();

            this.monthlyReport2017To2018List1.Fill();
            this.grdkol.Refetch();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.reportMounthlyLaboratory2017To2018List1.Fill();
            this.grdReport.Refetch();

            this.monthlyReport2017To2018List1.Fill();
            this.grdkol.Refetch();
        }

        private void groupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
