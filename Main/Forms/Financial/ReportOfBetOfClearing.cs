using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class ReportOfBetOfClearing : RASF.General.Forms.Base.DockContentForm
    {
        public ReportOfBetOfClearing()
        {
            InitializeComponent();
            this.reportOfCreditCompanyList1.spName = "ReportOfBetOfClearing";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           this.grdCash.ExportToExcel("گزارش شرکت های تحویل گزارش منوط به تسویه");
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
            report.Load(String.Format("{0}\\Report\\ReportOfBetOfClearing.mrt", Application.StartupPath));
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
