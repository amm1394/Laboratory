using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class WageofagencyPay : RASF.General.Forms.Base.DockContentForm
    {
        public WageofagencyPay()
        {
            InitializeComponent();
        }

        private void WageofagencyPay_Load(object sender, EventArgs e)
        {
            this.wageofagencyPayList1.Fill();
            this.grdWage.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.wageofagencyPayList1.Fill();
            this.grdWage.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdWage.ExportToExcel("کسر از کارمزد");
        }
    }
}
