using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class ReportOfCreditCompany_Fin : RASF.General.Forms.Base.DockContentForm
    {
        private Janus.Windows.GridEX.GridEXFormatStyle TwoFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle FourFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle ThirtyFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle ForthyFormat;
       // Int64 Mande;
      //  decimal Darsad;
        public ReportOfCreditCompany_Fin()
        {
            InitializeComponent();
            this.btnKol.Visible = false;

            this.TwoFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.TwoFormat.BackColor = Color.Yellow;
            this.TwoFormat.ForeColor = Color.Black;

            this.FourFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.FourFormat.BackColor = Color.Red;
            this.FourFormat.ForeColor = Color.Black;

            this.ThirtyFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.ThirtyFormat.BackColor = Color.Coral;
            this.ThirtyFormat.ForeColor = Color.Black;

            this.ForthyFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.ForthyFormat.BackColor = Color.Brown;
            this.ForthyFormat.ForeColor = Color.Black;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           this.grdCredit.ExportToExcel("گزارش شرکت های اعتباری");
        }

        private void ReportOfCreditCompany_Load(object sender, EventArgs e)
        {
            this.reportOfCreditCompanyList1.Fill();
            this.grdCredit.Refetch();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.reportOfCreditCompanyList1.Fill();
            this.grdCredit.Refetch();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            report.Load(String.Format("{0}\\Report\\ReportOfCreditCompany.mrt", Application.StartupPath));
            report.Show();
        }

        private void grdCredit_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.ReportOfCreditCompany CurrentRow = (RASF.General.Data.ReportOfCreditCompany)this.grdCredit.CurrentRow.DataRow;
            RASF.Main.Forms.Financial.ViewReceiptDemandForm ViewReceiptDemandForm = new Financial.ViewReceiptDemandForm(CurrentRow.CompaniesCode);
            ViewReceiptDemandForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.KolCredit KolCredit = new KolCredit();
            KolCredit.Show();

        }

        private void grdCredit_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (Convert.ToInt32(e.Row.Cells["Recdiif"].Value) > 60)
            {
                e.Row.Cells["ReceptionDate"].FormatStyle = this.TwoFormat;
            }

            if (Convert.ToInt32(e.Row.Cells["Recdiif"].Value) > 120)
            {
                e.Row.Cells["ReceptionDate"].FormatStyle = this.FourFormat;
            }

            if (Convert.ToInt32(e.Row.Cells["RecieptDiff"].Value) > 30)
            {
                e.Row.Cells["ReceiptDate"].FormatStyle = this.ThirtyFormat;
            }

            if (Convert.ToInt32(e.Row.Cells["RecieptDiff"].Value) >45)
            {
                e.Row.Cells["ReceiptDate"].FormatStyle = this.ForthyFormat;
            }
        }
    }
}
