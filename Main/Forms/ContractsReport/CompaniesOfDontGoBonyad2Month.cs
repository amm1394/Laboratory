using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.ContractsReport
{
    public partial class CompaniesOfDontGoBonyad2Month : RASF.General.Forms.Base.DockContentForm
    {
        private Int16 Month;
        private Janus.Windows.GridEX.GridEXFormatStyle NewCustomerFormat;
        public CompaniesOfDontGoBonyad2Month()
        {
            InitializeComponent();
            this.ShowpnlUpdate = false;

            this.NewCustomerFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.NewCustomerFormat.BackColor = Color.Plum;
            this.NewCustomerFormat.ForeColor = Color.Black;
        }

        private void ShowVoidedContracts_Load(object sender, EventArgs e)
        {
            Month = Convert.ToInt16(txtSearch.Text);
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@Month", Month));
            this.companiesOfDontGoBonyad2MonthList1.Fill(Parameter);
            this.grdCompany.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdCompany.ExportToExcel("");
        }

      

        private void btnSea_Click_1(object sender, EventArgs e)
        {
            Month = Convert.ToInt16(txtSearch.Text);
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@Month", Month));
            this.companiesOfDontGoBonyad2MonthList1.Fill(Parameter);
            this.grdCompany.Refetch();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog1.Document = gridEXPrintDocument1;
                printPreviewDialog1.ShowInTaskbar = true;
                printPreviewDialog1.MinimizeBox = true;
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.WindowState = FormWindowState.Minimized;
                gridEXPrintDocument1.DefaultPageSettings.Landscape = true;
                gridEXPrintDocument1.PrinterSettings.PrinterName = printDialog1.PrinterSettings.PrinterName;
                gridEXPrintDocument1.PrinterSettings.Copies = printDialog1.PrinterSettings.Copies;
                gridEXPrintDocument1.Print();
            }
        }

        private void grdCompany_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (Convert.ToInt16(e.Row.Cells["Morajeat"].Value) <= 10 && Convert.ToInt16(e.Row.Cells["Morajeat"].Value) > 0)
            {
                e.Row.Cells["CompanyName"].FormatStyle = this.NewCustomerFormat;
            }
        }

      
    }
}
