using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class ReportOfClearingBeforFactor : RASF.General.Forms.Base.DockContentForm
    {
        public ReportOfClearingBeforFactor()
        {
            InitializeComponent();
            this.reportOfCreditCompanyList1.spName = "ReportOfClearingBeforFactor";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           this.grdCash.ExportToExcel("گزارش شرکت های منوط به تسویه فاکتور قبل");
        }

        private void ReportOfCreditCompany_Load(object sender, EventArgs e)
        {
            this.reportOfCreditCompanyList1.Fill();
            this.grdCash.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.reportOfCreditCompanyList1.Fill();
            this.grdCash.Refetch();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            report.Load(String.Format("{0}\\Report\\ReportOfClearingBeforFactor.mrt", Application.StartupPath));
            report.Show();
        }

        private void grdCash_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.ReportOfCreditCompany CurrentRow = (RASF.General.Data.ReportOfCreditCompany)this.grdCash.CurrentRow.DataRow;
            RASF.Main.Forms.Financial.ViewReceiptDemandForm ViewReceiptDemandForm = new Financial.ViewReceiptDemandForm(CurrentRow.CompaniesCode);
            ViewReceiptDemandForm.Show();
        }
    }
}
