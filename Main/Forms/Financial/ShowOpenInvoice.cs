using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class ShowOpenInvoice : RASF.General.Forms.Base.DockContentForm
    {
        public ShowOpenInvoice()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
        }

        private void ShowOpenInvoice_Load(object sender, EventArgs e)
        {
            this.showOpenInvoiceList1.Fill();
            this.grdBill.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdBill.ExportToExcel("صورت حساب های باز");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.showOpenInvoiceList1.Fill();
            this.grdBill.Refetch();
        }

        private void grdBill_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.OpenCloseBill Current_Contract1 = (RASF.General.Data.OpenCloseBill)this.grdBill.SelectedItems[0].GetRow().DataRow;
            ((RASF.General.Data.OpenCloseBill)this.grdBill.SelectedItems[0].GetRow().DataRow).RowState = General.Enums.RowState.Updated;
            this.showOpenInvoiceList1.Update();

            this.showOpenInvoiceList1.Fill();
            this.grdBill.Refetch();
        }
    }
}
