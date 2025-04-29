using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class contactsiscompletednothasinvoiceForm : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
        public contactsiscompletednothasinvoiceForm()
        {
            InitializeComponent();
            this.To = this.From = System.DateTime.Now;
            this.ShowpnlSave = true ;
            this.ShowpnlExit = false;

        }

        private void ReceiveChequeForm_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("From", this.From));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("To", this.To));
            this.contactsiscompletednothasinvoiceList1.Fill(Parameters);
            this.grdContract.Refetch();
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.contactsiscompletednothasinvoiceList1.Fill(Parameters);
            

            this.grdContract.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //report.Load(String.Format("{0}\\Report\\ReceiveCheque.mrt", Application.StartupPath));
            //report["@From"] = From;
            //report["@To"] = To;
            //report.Show();
            //if (printDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    printPreviewDialog1.Document = gridEXPrintDocument1;
            //    printPreviewDialog1.ShowInTaskbar = true;
            //    printPreviewDialog1.MinimizeBox = true;
            //    printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            //    printPreviewDialog1.WindowState = FormWindowState.Minimized;
            //    gridEXPrintDocument1.DefaultPageSettings.Landscape = true;
            //    gridEXPrintDocument1.PrinterSettings.PrinterName = printDialog1.PrinterSettings.PrinterName;
            //    gridEXPrintDocument1.PrinterSettings.Copies = printDialog1.PrinterSettings.Copies;
            //    gridEXPrintDocument1.Print();
            //}
            this.grdContract.ExportToExcel("قراردادهایی که صورت حساب ندارند");

        }
    }
}
