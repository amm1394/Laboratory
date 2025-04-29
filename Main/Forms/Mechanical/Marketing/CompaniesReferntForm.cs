using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Marketing
{
    public partial class CompaniesReferntForm : RASF.General.Forms.Base.DockContentForm
    {
        public CompaniesReferntForm()
        {
            InitializeComponent();
        }

        private void CompaniesReferntForm_Load(object sender, EventArgs e)
        {
            this.companiesReferntList1.Fill();
            this.grdCompaneis.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdCompaneis.ExportToExcel("کارهای ارجاعی شرکت ها");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.companiesReferntList1.Fill();
            this.grdCompaneis.Refetch();
        }
    }
}
