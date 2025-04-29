using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.ContractsReport
{
    public partial class ContractsNotenteredintotheLaboratory : RASF.General.Forms.Base.DockContentForm
    {
        private Janus.Windows.GridEX.GridEXFormatStyle TestFormat;

        public ContractsNotenteredintotheLaboratory()
        {
            InitializeComponent();
            this.TestFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.TestFormat.BackColor = Color.Yellow;
            this.TestFormat.ForeColor = Color.Black;
        }

        private void ContractsenteredintotheLaboratory_Load(object sender, EventArgs e)
        {
            this.contractsNotenteredintotheLaboratoryList1.Fill();
            this.grdContracts.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdContracts.ExportToExcel("قراردادهایی که وارد آزمایشگاه نشده اند");
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.ContractsenteredintotheLaboratory CurrentRow = (RASF.General.Data.ContractsenteredintotheLaboratory)this.grdContracts.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.contractsNotenteredintotheLaboratoryList1.Fill();
            this.grdContracts.Refetch();
        }

        private void grdContracts_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (Convert.ToString(e.Row.Cells["DateOfTestForThePresence"].Value) != "")
            {
                e.Row.Cells["DateOfTestForThePresence"].FormatStyle = this.TestFormat;
            }
        }
    }
}
