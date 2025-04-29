using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class RemindDebtorYearToYearForAlpha : RASF.General.Forms.Base.DockContentForm
    {
        public RemindDebtorYearToYearForAlpha()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlSave = false;
            this.remindDebtorYearToYearList1.spName = "RemindDebtorYearToYearPlusForAlpha";
            this.darsadAndRemindList1.spName = "DarsadAndRemindPlusForAlpha";
        }

        private void RemindDebtorYearToYear_Load(object sender, EventArgs e)
        {
            this.remindDebtorYearToYearList1.Fill();
            this.grdReport.Refetch();

            this.remindDebtorYearToYearAlphaList1.Fill();
            this.grdAlpha.Refetch();

            this.darsadAndRemindList1.Fill();
            this.grdKol.Refetch();
            this.grid1.Refetch();
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
