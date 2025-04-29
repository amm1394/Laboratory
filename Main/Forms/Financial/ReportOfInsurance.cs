using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class ReportOfInsurance : RASF.General.Forms.Base.DockContentForm
    {
        public ReportOfInsurance()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
            this.repotOfGrantList1.spName = "ReportOfInsurance";
        }

        private void RepotOfGrant_Load(object sender, EventArgs e)
        {
            this.repotOfGrantList1.Fill();
            this.grdgrant.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdgrant.ExportToExcel("بیمه های ثبت شده");
        }
    }
}
