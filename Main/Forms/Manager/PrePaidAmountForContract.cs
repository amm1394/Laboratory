using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class PrePaidAmountForContract : RASF.General.Forms.Base.DockContentForm
    {
        public PrePaidAmountForContract()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.officesFinancialList1.spName = "KasrKarmozd";
        }

        private void PrePaidAmountForContract_Load(object sender, EventArgs e)
        {
            this.prePaidAmountForContractList1.Fill();
            this.grdReports.Refetch();

            this.officesFinancialList1.Fill();
            this.grdAgency.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.prePaidAmountForContractList1.Fill();
            this.grdReports.Refetch();

            this.officesFinancialList1.Fill();
            this.grdAgency.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdReports.ExportToExcel("مبالغ از پیش دریافت شده");
        }

        private void grdReports_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.DeliveryDay CurrentRow = (RASF.General.Data.DeliveryDay)this.grdReports.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }
    }
}
