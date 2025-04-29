using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.SEM
{
    public partial class Report : RASF.General.Forms.Base.DockContentForm
    {
        public Report()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlSave = false;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            this.timingSEMCanceledList1.Fill();
            this.grdCancel.Refetch();

            this.timingSEMNoCustomerPresenceList1.Fill();
            this.grdNoCustomer.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.timingSEMCanceledList1.Fill();
            this.grdCancel.Refetch();

            this.timingSEMNoCustomerPresenceList1.Fill();
            this.grdNoCustomer.Refetch();
        }
    }
}
