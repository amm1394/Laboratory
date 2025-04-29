using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace RASF.Main.Forms.Financial
{
    public partial class CompanyWorkFlow : RASF.General.Forms.Base.DockContentForm
    {
        private Janus.Windows.GridEX.GridEXFormatStyle KarmozdFormat;
        public CompanyWorkFlow()
        {
            InitializeComponent();
            this.KarmozdFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.KarmozdFormat.BackColor = Color.DarkRed;
            this.KarmozdFormat.ForeColor = Color.White;
          
        }


        private void CompanyWorkFlow_Load(object sender, EventArgs e)
        {
            this.debtorCreditorCompaniesWorkFlowList1.Fill();
            this.grdCompanies.Refetch();
        }

        private void grdCompanies_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdCompanies.CurrentRow != null) && (this.grdCompanies.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpCompanies.Text = String.Format("قرارداد {0}", this.grdCompanies.CurrentRow.Cells["CompanyName"].Value);
                List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                Parameters.Add(new System.Data.SqlClient.SqlParameter("CmpaniesCode", this.grdCompanies.CurrentRow.Cells["CompaniesCode"].Value));
                this.companyWorkFlowList1.Fill(Parameters);

                this.grdWorkFlow.Refetch();
            }
            else
            {
                this.grpCompanies.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdCompanies.ExportToExcel("گردش مالی");
          //  this.grdWorkFlow.ExportToExcel(this.grdCompanies.CurrentRow.Cells["CompanyName"].Value.ToString());
            this.grdWorkFlow.ExportToExcel("جزئیات گردش مالی");
        }

        private void grdWorkFlow_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.CompanyWorkFlow CurrentRow = (RASF.General.Data.CompanyWorkFlow)this.grdWorkFlow.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.MdiParent = this.MdiParent;
            CostPaper.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report2.Load(String.Format("{0}\\Report\\ReportingOfCompaniesWorkFlowForPrint.mrt", Application.StartupPath));
            Report2["@CompaniesCode"] = this.grdCompanies.CurrentRow.Cells["CompaniesCode"].Value;
            Report2.Show();
                            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.debtorCreditorCompaniesWorkFlowList1.Fill();
            this.grdCompanies.Refetch();

            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("CmpaniesCode", this.grdCompanies.CurrentRow.Cells["CompaniesCode"].Value));
            this.companyWorkFlowList1.Fill(Parameters);
            grdWorkFlow.Refetch();
      }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.debtorCreditorCompaniesWorkFlowList1.Fill();
            this.grdCompanies.Refetch();
        }


        private void grdWorkFlow_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if ((e.Row.Cells["TypeInvoice"].Value is NotFinancialCreditCompany != null) && (e.Row.Cells["TypeInvoice"].Value.ToString() == "کسر از کارمزد"))
            {
                e.Row.Cells["TypeInvoice"].FormatStyle = this.KarmozdFormat;
            }

        }

        private void grpCompanies_Click(object sender, EventArgs e)
        {

        }

        
    }
}
