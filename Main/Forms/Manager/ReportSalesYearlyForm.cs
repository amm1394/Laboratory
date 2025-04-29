using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class ReportSalesYearlyForm : RASF.General.Forms.Base.DockContentForm
    {
        public ReportSalesYearlyForm()
        {
            InitializeComponent();
        }

        private void ReportSalesYearlyForm_Load(object sender, EventArgs e)
        {
            this.reportSalesYearlyList1.Fill();
            this.grdLab.Refetch();
        }
    }
}
