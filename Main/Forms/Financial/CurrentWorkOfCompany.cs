using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class CurrentWorkOfCompany : RASF.General.Forms.Base.DockContentForm
    {
        public CurrentWorkOfCompany()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
        }

        private void CurrentWorkOfCompany_Load(object sender, EventArgs e)
        {
            this.currentWorkOfCompanyList1.Fill();
            this.grdCo.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdCo.ExportToExcel("");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.currentWorkOfCompanyList1.Fill();
            this.grdCo.Refetch();
        }
    }
}
