using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class GiveReportDependOnClearing : RASF.General.Forms.Base.DockContentForm
    {
        public GiveReportDependOnClearing()
        {
            InitializeComponent();
            this.creditreportingcompaniesList1.spName = "GiveReportDependOnClearingcompanies";
        }

        private void Creditreportingcompanies_Load(object sender, EventArgs e)
        {
            this.creditreportingcompaniesList1.Fill();
            this.grdCredit.Refetch();
        }

     

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdCredit.ExportToExcel("شرکت های تحویل گزارش منوط به تسویه");
            this.grdWorkFlow.ExportToExcel(this.grdCredit.CurrentRow.Cells["CompanyName"].Value.ToString());
        }

        private void grdCredit_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdCredit.CurrentRow != null) && (this.grdCredit.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpCredit.Text = String.Format("قرارداد {0}", this.grdCredit.CurrentRow.Cells["CompanyName"].Value);
                List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                Parameters.Add(new System.Data.SqlClient.SqlParameter("CmpaniesCode", this.grdCredit.CurrentRow.Cells["CompaniesCode"].Value));
                this.creditCompanyWorkFlowList1.Fill(Parameters);

                grdWorkFlow.Refetch();
            }
            else
            {
                this.grpCredit.Text = "";
            }
        }

        private void grdWorkFlow_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.CreditCompanyWorkFlow CurrentRow = (RASF.General.Data.CreditCompanyWorkFlow)this.grdWorkFlow.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.MdiParent = this.MdiParent;
            CostPaper.Show();
        }
    }
}
