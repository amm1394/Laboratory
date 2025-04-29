using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class RemindDebtorYearToYear : RASF.General.Forms.Base.DockContentForm
    {
        public RemindDebtorYearToYear()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlSave = false;
        }

        private void RemindDebtorYearToYear_Load(object sender, EventArgs e)
        {
            this.remindDebtorYearToYearList1.Fill();
            this.grdReport.Refetch();

            this.darsadAndRemindList1.Fill();
            this.grdKol.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.remindDebtorYearToYearList1.Fill();
            this.grdReport.Refetch();

            this.darsadAndRemindList1.Fill();
            this.grdKol.Refetch();
        }
    }
}
