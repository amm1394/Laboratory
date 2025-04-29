using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class ContractIsVoidSegregate : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
        public ContractIsVoidSegregate()
        {
            InitializeComponent();
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
        }

        private void DailyProcessReport_Load(object sender, EventArgs e)
        {
            pickDate2_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            //this.From = e.From;
            //this.To = e.To;
            //List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
            //Parameters1.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            //Parameters1.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            //this.dailyProcessReportList1.Fill(Parameters1);
            //grdReport.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdReportDaily.ExportToExcel("قراردادهای ابطال شده");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog1.Document = gridEXPrintDocument1;
                printPreviewDialog1.ShowInTaskbar = true;
                printPreviewDialog1.MinimizeBox = true;
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.WindowState = FormWindowState.Maximized;
                gridEXPrintDocument1.DefaultPageSettings.Landscape = true;
                gridEXPrintDocument1.PrinterSettings.PrinterName = printDialog1.PrinterSettings.PrinterName;
                gridEXPrintDocument1.PrinterSettings.Copies = printDialog1.PrinterSettings.Copies;
                gridEXPrintDocument1.Print();
            }

          
        }

        private void pickDate2_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            this.From = e.From;
            this.To = e.To;
            List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.contractIsVoidSegregateList1.Fill(Parameters1);
            grdReportDaily.Refetch();
        }
    }
}
