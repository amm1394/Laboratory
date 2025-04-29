using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Marketing
{
    public partial class CompanyMarking : RASF.General.Forms.Base.DockContentForm
    {
        public CompanyMarking()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
        }

        private void CompanyMarking_Load(object sender, EventArgs e)
        {
            this.companiesBaseList1.Fill();
            this.grdCompany.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.companiesBaseList1.Fill();
            this.grdCompany.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdCompany.ExportToExcel("شرکت ها");
        }
    }
}
