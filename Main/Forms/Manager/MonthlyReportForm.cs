using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class MonthlyReportForm : RASF.General.Forms.Base.DockContentForm
    {
        public MonthlyReportForm()
        {
            InitializeComponent();
        }

        private void MonthlyReportForm_Load(object sender, EventArgs e)
        {
            this.monthlyReportList1.Fill();
            this.grdreport.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.monthlyReportList1.Fill();
            this.grdreport.Refetch();
        }
    }
}
