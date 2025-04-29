using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Receipt
{
    public partial class Theamountofdailyintake : RASF.General.Forms.Base.DockContentForm
    {
        public Theamountofdailyintake()
        {
            InitializeComponent();
        }

        public DateTime From;
        public DateTime To;

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            //if (printDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    printPreviewDialog1.Document = gridEXPrintDocument1;
            //    printPreviewDialog1.ShowInTaskbar = true;
            //    printPreviewDialog1.MinimizeBox = true;
            //    printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            //    printPreviewDialog1.WindowState = FormWindowState.Maximized;
            //    gridEXPrintDocument1.DefaultPageSettings.Landscape = true;
            //    gridEXPrintDocument1.PrinterSettings.PrinterName = printDialog1.PrinterSettings.PrinterName;
            //    gridEXPrintDocument1.PrinterSettings.Copies = printDialog1.PrinterSettings.Copies;
            //    gridEXPrintDocument1.Print();
            //}

            report.Load(String.Format("{0}\\Report\\ReportOfTheamountofdailyintake.mrt", Application.StartupPath));
            report["@From"] = From;
            report["@To"] = To;
            report.Show();
     
          
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.theamountofdailyintakeList1.Fill(Parameter);

            From = e.From; To = e.To; 

            grdOffices.Refetch();

        }

        private void Theseparationofoffices_Load(object sender, EventArgs e)
        {
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }

        private void grdOffices_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            //RASF.General.Data.Theamountofdailyintake CurrentRow = (RASF.General.Data.Theamountofdailyintake)this.grdOffices.CurrentRow.DataRow;
            //RASF.Main.Forms.Receipt.Turnoverreached Turnoverreached = new Receipt.Turnoverreached(CurrentRow.ReceiptAmountMasterCode);
            //Turnoverreached.Show();
             switch (e.Column.Key)
            {
                 case "ReceiptNo":

            if (Convert.ToInt16(this.grdOffices.CurrentRow.Cells["ReceieptCode"].Value) == 1)
            {

                report.Load(String.Format("{0}\\Report\\Receiptoffunds.mrt", Application.StartupPath));
                report["@ReceiptAmountMasterCode"] = this.grdOffices.CurrentRow.Cells["ReceiptAmountMasterCode"].Value;
                report.Show();
            }

            if (Convert.ToInt16(this.grdOffices.CurrentRow.Cells["ReceieptCode"].Value) == 16)
            {

                report.Load(String.Format("{0}\\Report\\ReceiptofGrant.mrt", Application.StartupPath));
                report["@ReceiptAmountMasterCode"] = this.grdOffices.CurrentRow.Cells["ReceiptAmountMasterCode"].Value;
                report.Show();
            }

            if (Convert.ToInt16(this.grdOffices.CurrentRow.Cells["ReceieptCode"].Value) == 2)
            {

                report.Load(String.Format("{0}\\Report\\ReceiptCheque.mrt", Application.StartupPath));
                report["@ReceiptAmountMasterCode"] = this.grdOffices.CurrentRow.Cells["ReceiptAmountMasterCode"].Value;
                report.Show();
            }

            if (Convert.ToInt16(this.grdOffices.CurrentRow.Cells["ReceieptCode"].Value) == 3)
            {

                report.Load(String.Format("{0}\\Report\\ReceiptofMoneyOrder.mrt", Application.StartupPath));
                report["@ReceiptAmountMasterCode"] = this.grdOffices.CurrentRow.Cells["ReceiptAmountMasterCode"].Value;
                report.Show();
            }
                     break;
                 case "Name":
                      RASF.General.Data.Theamountofdailyintake CurrentRow = (RASF.General.Data.Theamountofdailyintake)this.grdOffices.CurrentRow.DataRow;
                      RASF.Main.Forms.Financial.SaveCheque SaveCheque = new RASF.Main.Forms.Financial.SaveCheque(CurrentRow.ReceiptAmountMasterCode);
                      SaveCheque.Show();
                     break;

             }
        }

        private void pickDate1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            grdOffices.ExportToExcel("مبالغ دریافتی");
        }

      

       
    }
}
