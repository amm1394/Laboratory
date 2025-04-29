using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class ReportOfCompanyKol_1 : RASF.General.Forms.Base.DockContentForm
    {
        private Janus.Windows.GridEX.GridEXFormatStyle TwoFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle FourFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle ThirtyFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle ForthyFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle EtebariFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle NewCustomerFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle NotInvoiceFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle FourtyPercentageOFCredit;
       
        //Int64 Mande;
        //decimal Darsad;
        public ReportOfCompanyKol_1()
        {
            InitializeComponent();
            btnKol.Visible = false;
            this.reportOfCreditCompanyList1.spName = "ReportOfCompanyKol";

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

            this.EtebariFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.EtebariFormat.BackColor = Color.Orange;
            this.EtebariFormat.ForeColor = Color.Black;

            this.NewCustomerFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.NewCustomerFormat.BackColor = Color.Plum;
            this.NewCustomerFormat.ForeColor = Color.Black;

            this.NotInvoiceFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.NotInvoiceFormat.BackColor = Color.Green;
            this.NotInvoiceFormat.ForeColor = Color.Black;

            this.FourtyPercentageOFCredit = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.FourtyPercentageOFCredit.BackColor = Color.DarkOrange;
            this.FourtyPercentageOFCredit.ForeColor = Color.Black;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           this.grdCash.ExportToExcel("گزارش شرکت ها");
        }

        private void ReportOfCreditCompany_Load(object sender, EventArgs e)
        {
            //List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            //Parameters.Add(new System.Data.SqlClient.SqlParameter("@light", lightName1.LightCode));
            //this.reportOfCreditCompanyList1.Fill(Parameters);
        //    this.grdCash.Refetch();

            //this.darsadGreenRedList1.Fill();
            //this.grdDarsad.Refetch();
 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@light", lightName1.LightCode));
            this.reportOfCreditCompanyList1.Fill(Parameters);
            this.grdCash.Refetch();

            //this.darsadGreenRedList1.Fill();
            //this.grdDarsad.Refetch();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            report.Load(String.Format("{0}\\Report\\ReportOfCashCompany.mrt", Application.StartupPath));
            report.Show();
        }

        private void grdCash_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            //RASF.General.Data.ReportOfCreditCompany CurrentRow = (RASF.General.Data.ReportOfCreditCompany)this.grdCash.CurrentRow.DataRow;
            //RASF.Main.Forms.Financial.ViewReceiptDemandForm ViewReceiptDemandForm = new Financial.ViewReceiptDemandForm(CurrentRow.CompaniesCode);
            //ViewReceiptDemandForm.Show();

            RASF.General.Data.ReportOfCreditCompany CurrentRow = (RASF.General.Data.ReportOfCreditCompany)this.grdCash.CurrentRow.DataRow;
            RASF.Main.Forms.Financial.StatusInsurancedeductionsDescription Info_PeapleRelated = new Financial.StatusInsurancedeductionsDescription(CurrentRow.CompaniesCode);
            Info_PeapleRelated.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.KolCash KolCash = new KolCash();
            KolCash.Show();
        }

        private void grdCash_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (Convert.ToInt32(e.Row.Cells["Recdiif"].Value)  >60)
            {
                e.Row.Cells["ReceptionDate"].FormatStyle = this.TwoFormat;
            }

            if (Convert.ToInt32(e.Row.Cells["Recdiif"].Value) >120)
            {
                e.Row.Cells["ReceptionDate"].FormatStyle = this.FourFormat;
            }

            if (Convert.ToInt32(e.Row.Cells["RecieptDiff"].Value) > 30)
            {
                e.Row.Cells["ReceiptDate"].FormatStyle = this.ThirtyFormat;
            }

            if (Convert.ToInt32(e.Row.Cells["RecieptDiff"].Value) > 45)
            {
                e.Row.Cells["ReceiptDate"].FormatStyle = this.ForthyFormat;
            }

             string Contains1 = Convert.ToString(e.Row.Cells["CooperationName"].Value);
             if (Contains1.Contains("اعتباری"))
             {
                 e.Row.Cells["CompanyName"].FormatStyle = this.EtebariFormat;
                 e.Row.Cells["CooperationName"].FormatStyle = this.EtebariFormat;

                 if (Convert.ToInt64(e.Row.Cells["Notinvoice"].Value) > Convert.ToInt64(e.Row.Cells["Credit"].Value))
                 {
                     if (Convert.ToInt64(e.Row.Cells["Notinvoice"].Value) <= Convert.ToInt64(e.Row.Cells["FourtyPercentageOFCredit"].Value))
                     {
                         e.Row.Cells["Notinvoice"].FormatStyle = this.FourtyPercentageOFCredit;
                     }
                     else
                     {
                         e.Row.Cells["Notinvoice"].FormatStyle = this.FourFormat;
                     }
                 }
                 else
                 {
                     e.Row.Cells["Notinvoice"].FormatStyle = this.NotInvoiceFormat;
                 }
             }

          

            if (Convert.ToInt16(e.Row.Cells["Morajeat"].Value) <= 10 && Convert.ToInt16(e.Row.Cells["Morajeat"].Value) > 0 && Convert.ToInt16(e.Row.Cells["HaghHogh"].Value) != 0)
            {
                e.Row.Cells["CompanyName"].FormatStyle = this.NewCustomerFormat;
            }

        }

        private void lightName1_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@light", lightName1.LightCode));
            this.reportOfCreditCompanyList1.Fill(Parameters);
            this.grdCash.Refetch();
        }

        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@light", lightName1.LightCode));
            this.reportOfCreditCompanyList1.Fill(Parameters);
            this.grdCash.Refetch();
        }
    }
}
