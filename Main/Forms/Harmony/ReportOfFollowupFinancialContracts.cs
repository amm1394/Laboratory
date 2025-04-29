using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class ReportOfFollowupFinancialContracts : RASF.General.Forms.Base.DockContentForm
    {
        public ReportOfFollowupFinancialContracts()
        {
            InitializeComponent();
        }

        private void IsHoldForm_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void grdIsHold_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdFinancial.CurrentRow != null) && (this.grdFinancial.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpGrid.Text = "قرارداد" + " " + this.grdFinancial.CurrentRow.Cells["ContractNo"].Value.ToString();
            }
            else
            {
                this.grpGrid.Text = "";
            }
           
        }

        private void FillGrid()
        {
            this.followupFinancialContractsList1.Fill();
            this.grdFinancial.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdFinancial.ExportToExcel("تایید مالی نشده ها"); 
        }

        private void grdFinancial_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.Contracts_IsHold CurrentRow = (RASF.General.Data.Contracts_IsHold)this.grdFinancial.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ReportDetailFollowupFinancialContracts Report = new Harmony.ReportDetailFollowupFinancialContracts(CurrentRow.ContractsCode);
            Report.Show();
        }


    }
}
