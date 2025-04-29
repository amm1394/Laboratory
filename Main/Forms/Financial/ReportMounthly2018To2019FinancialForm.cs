using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class ReportMounthly2018To2019FinancialForm : RASF.General.Forms.Base.DockContentForm
    {
        public ReportMounthly2018To2019FinancialForm()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
          //  this.ShowpnlSave = false;
            this.reportMounthlyLaboratory2017To2018List1.spName = "ReportMounthlyLaboratory2018To2019";
            this.monthlyReport2017To2018List1.spName = "MonthlyReport2018To2019";

        }

        private void ReportMounthlyLaboratoryForm_Load(object sender, EventArgs e)
        {
           this.reportMounthlyLaboratory2017To2018List1.Fill();
           this.grdReport.Refetch();

            this.monthlyReport2017To2018List1.Fill();
            this.grdkol.Refetch();

            this.darsadAndRemindList1.Fill();
            this.grdDarsad.Refetch();

            this.remindSeparatedbycustomerCashList1.Fill();
            this.grdCash.Refetch();

            this.remindSeparatedbycustomerCreditorList1.Fill();
            this.grdCredit.Refetch();

            this.remindDebtorYearToYearList1.Fill();
            this.grid1.Refetch();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.reportMounthlyLaboratory2017To2018List1.Fill();
            this.grdReport.Refetch();

            this.monthlyReport2017To2018List1.Fill();
            this.grdkol.Refetch();

            this.darsadAndRemindList1.Fill();
            this.grdDarsad.Refetch();

            this.remindSeparatedbycustomerCashList1.Fill();
            this.grdCash.Refetch();

            this.remindSeparatedbycustomerCreditorList1.Fill();
            this.grdCredit.Refetch();

            this.remindDebtorYearToYearList1.Fill();
            this.grid1.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ماهانه آزمایشگاه ها");
            this.grdReport.ExportToExcel("گزارش ماهانه آزمایشگاه ها");
            MessageBox.Show("ماهانه کل");
            this.grdkol.ExportToExcel("گزارش ماهانه کل");
            MessageBox.Show("درصد مانده ها");
            this.grdDarsad.ExportToExcel("گزارش درصد مانده ها");
        }

        private void grdkol_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.MonthlyReport CurrentRow = (RASF.General.Data.MonthlyReport)this.grdkol.CurrentRow.DataRow;
            RASF.Main.Forms.Manager.DetaiolOfRecieptForm Detail = new Manager.DetaiolOfRecieptForm(CurrentRow.Id);
            Detail.Show();
        }

    }
}
