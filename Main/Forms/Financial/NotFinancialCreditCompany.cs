using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class NotFinancialCreditCompany : RASF.General.Forms.Base.DockContentForm
    {
        public NotFinancialCreditCompany()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
            this.financiacceptList1.spName = "NotFinancialCreditCompany";
        }

        private void showNotFinancialForOffices_Load(object sender, EventArgs e)
        {
            this.financiacceptList1.Fill();
            this.grdContracts.Refetch();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdContracts.ExportToExcel("");
        }
    }
}
