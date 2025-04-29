using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class DebtorInvoice : RASF.General.Forms.Base.DockContentForm
    {
        public DebtorInvoice()
        {
            InitializeComponent();
            this.ShowpnlUpdate = true;
        }

        private void DebtorInvoice_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            this.debtorInvoiceList1.Fill();

            this.grdContracts.Refetch();
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.DebtorInvoice CurrentRow = (RASF.General.Data.DebtorInvoice)this.grdContracts.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdContracts.ExportToExcel("فاکتورهای تسویه نشده");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RefreshGrid(); 
        }

      
    }
}
