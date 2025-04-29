using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class ReportOfVoidBill : RASF.General.Forms.Base.DockContentForm
    {
        public ReportOfVoidBill()
        {
            InitializeComponent();
        }

        private void grid1_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }

        private void ReportOfVoidBill_Load(object sender, EventArgs e)
        {
            this.reportOfVoidBillList1.Fill();
            this.grid1.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grid1.ExportToExcel("صورت حساب های باطل شده");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.reportOfVoidBillList1.Fill();
            this.grid1.Refetch();
        }

        private void grid1_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.MasterBillVoid CurrentRow = (RASF.General.Data.MasterBillVoid)this.grid1.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper ViewCostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            ViewCostPaper.Show();
        }
    }
}
