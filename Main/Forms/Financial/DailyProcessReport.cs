using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class DailyProcessReport : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
        private Janus.Windows.GridEX.GridEXFormatStyle Plus;
        private Janus.Windows.GridEX.GridEXFormatStyle Negative;
        public DailyProcessReport()
        {
            InitializeComponent();
            pickDate2_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;

            this.Negative = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.Negative.ForeColor = Color.DarkRed;

            this.Plus = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.Plus.ForeColor = Color.DarkGreen;
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
            grdReportDaily.ExportToExcel("گزارش عملکرد روزانه");
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
            From = e.From;
            To = e.To;
            if (e.From == DateTime.MinValue || e.To == DateTime.MinValue)
            {
                From = DateTime.Now; To = DateTime.Now;
            }
            else
            {
                this.From = e.From;
                this.To = e.To;
                List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
                Parameters1.Add(new System.Data.SqlClient.SqlParameter("From", From));
                Parameters1.Add(new System.Data.SqlClient.SqlParameter("To", To));
                this.dailyProcessReportList1.Fill(Parameters1);
                this.grdReportDaily.Refetch();

                //List<System.Data.SqlClient.SqlParameter> Parameters2 = new List<System.Data.SqlClient.SqlParameter>();
                //Parameters2.Add(new System.Data.SqlClient.SqlParameter("From", From));
                //Parameters2.Add(new System.Data.SqlClient.SqlParameter("To", To));
                //this.avg97List1.Fill(Parameters2);
                //this.grdavg.Refetch();

                List<System.Data.SqlClient.SqlParameter> Parameters3 = new List<System.Data.SqlClient.SqlParameter>();
                Parameters3.Add(new System.Data.SqlClient.SqlParameter("From", From));
                Parameters3.Add(new System.Data.SqlClient.SqlParameter("To", To));
                this.avg98List1.Fill(Parameters3);
                this.grdAvg98.Refetch();

                List<System.Data.SqlClient.SqlParameter> Parameters4 = new List<System.Data.SqlClient.SqlParameter>();
                Parameters4.Add(new System.Data.SqlClient.SqlParameter("From", From));
                Parameters4.Add(new System.Data.SqlClient.SqlParameter("To", To));
                this.avg99List1.Fill(Parameters4);
                this.grdavg99.Refetch();

                //List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                //Parameter.Add(new System.Data.SqlClient.SqlParameter("@From", From));
                //Parameter.Add(new System.Data.SqlClient.SqlParameter("@To", To));
                //this.label2.Text = Convert.ToDecimal(RASF.General.Lists.Base.BaseList<Object>.FillScalar("DarsadRecieption_Select", Parameter)).ToString("#,#");

                //if (Convert.ToInt64(this.label2.Text) > 0)
                //{
                //    this.label2.ForeColor = Color.DarkGreen;
                //}
                //else
                //{
                //    this.label2.ForeColor = Color.DarkRed;
                //}
            }
        }

        private void grdReportDaily_SizeChanged(object sender, EventArgs e)
        {
            foreach (Janus.Windows.GridEX.GridEXColumn col in this.grdReportDaily.RootTable.Columns)
            {
                if (col.Visible == true)
                {
                    col.Width = (int)((Convert.ToInt16(col.Tag) / 100f) * (this.grdReportDaily.Width - 20));
                }
            }
        }

        private void grdReportDaily_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }

        //private void grdavg_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        //{
        //    if (Convert.ToDecimal(e.Row.Cells["Recipt_Amount"].Value) > 0)
        //    {
        //        e.Row.Cells["Recipt_Amount"].FormatStyle = this.Plus;
        //    }
        //    else
        //    {
        //        e.Row.Cells["Recipt_Amount"].FormatStyle = this.Negative;
        //    }

        //    if (Convert.ToDecimal(e.Row.Cells["FinancialAmount"].Value) > 0)
        //    {
        //        e.Row.Cells["FinancialAmount"].FormatStyle = this.Plus;
        //    }
        //    else
        //    {
        //        e.Row.Cells["FinancialAmount"].FormatStyle = this.Negative;
        //    }

        //    if (Convert.ToDecimal(e.Row.Cells["Bill_Amount"].Value) > 0)
        //    {
        //        e.Row.Cells["Bill_Amount"].FormatStyle = this.Plus;
        //    }
        //    else
        //    {
        //        e.Row.Cells["Bill_Amount"].FormatStyle = this.Negative;
        //    }

        //    if (Convert.ToDecimal(e.Row.Cells["TotalDisCount"].Value) > 0)
        //    {
        //        e.Row.Cells["TotalDisCount"].FormatStyle = this.Plus;
        //    }
        //    else
        //    {
        //        e.Row.Cells["TotalDisCount"].FormatStyle = this.Negative;
        //    }

        //    if (Convert.ToDecimal(e.Row.Cells["TotalTax"].Value) > 0)
        //    {
        //        e.Row.Cells["TotalTax"].FormatStyle = this.Plus;
        //    }
        //    else
        //    {
        //        e.Row.Cells["TotalTax"].FormatStyle = this.Negative;
        //    }

        //    if (Convert.ToDecimal(e.Row.Cells["BillWithTax"].Value) > 0)
        //    {
        //        e.Row.Cells["BillWithTax"].FormatStyle = this.Plus;
        //    }
        //    else
        //    {
        //        e.Row.Cells["BillWithTax"].FormatStyle = this.Negative;
        //    }

        //    if (Convert.ToDecimal(e.Row.Cells["DeliveryAmount"].Value) > 0)
        //    {
        //        e.Row.Cells["DeliveryAmount"].FormatStyle = this.Plus;
        //    }
        //    else
        //    {
        //        e.Row.Cells["DeliveryAmount"].FormatStyle = this.Negative;
        //    }

        //    if (Convert.ToDecimal(e.Row.Cells["Pay_Amount_Type_1"].Value) > 0)
        //    {
        //        e.Row.Cells["Pay_Amount_Type_1"].FormatStyle = this.Plus;
        //    }
        //    else
        //    {
        //        e.Row.Cells["Pay_Amount_Type_1"].FormatStyle = this.Negative;
        //    }

        //    if (Convert.ToDecimal(e.Row.Cells["Pay_Amount_Type_2"].Value) > 0)
        //    {
        //        e.Row.Cells["Pay_Amount_Type_2"].FormatStyle = this.Plus;
        //    }
        //    else
        //    {
        //        e.Row.Cells["Pay_Amount_Type_2"].FormatStyle = this.Negative;
        //    }

        //    if (Convert.ToDecimal(e.Row.Cells["Pay_Amount_Type_3"].Value) > 0)
        //    {
        //        e.Row.Cells["Pay_Amount_Type_3"].FormatStyle = this.Plus;
        //    }
        //    else
        //    {
        //        e.Row.Cells["Pay_Amount_Type_3"].FormatStyle = this.Negative;
        //    }

        //    if (Convert.ToDecimal(e.Row.Cells["Pay_Amount"].Value) > 0)
        //    {
        //        e.Row.Cells["Pay_Amount"].FormatStyle = this.Plus;
        //    }
        //    else
        //    {
        //        e.Row.Cells["Pay_Amount"].FormatStyle = this.Negative;
        //    }
        //}

        //private void grdavg_SizeChanged(object sender, EventArgs e)
        //{
        //    foreach (Janus.Windows.GridEX.GridEXColumn col in this.grdavg.RootTable.Columns)
        //    {
        //        if (col.Visible == true)
        //        {
        //            col.Width = (int)((Convert.ToInt16(col.Tag) / 100f) * (this.grdavg.Width - 20));
        //        }
        //    }
        //}

        private void grdAvg98_SizeChanged(object sender, EventArgs e)
        {
            foreach (Janus.Windows.GridEX.GridEXColumn col in this.grdAvg98.RootTable.Columns)
            {
                if (col.Visible == true)
                {
                    col.Width = (int)((Convert.ToInt16(col.Tag) / 100f) * (this.grdAvg98.Width - 20));
                }
            }
        }

        private void grdavg99_SizeChanged(object sender, EventArgs e)
        {
            foreach (Janus.Windows.GridEX.GridEXColumn col in this.grdavg99.RootTable.Columns)
            {
                if (col.Visible == true)
                {
                    col.Width = (int)((Convert.ToInt16(col.Tag) / 100f) * (this.grdavg99.Width - 20));
                }
            }
        }

        private void grdavg99_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (Convert.ToDecimal(e.Row.Cells["Recipt_Amount"].Value) > 0)
            {
                e.Row.Cells["Recipt_Amount"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["Recipt_Amount"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["FinancialAmount"].Value) > 0)
            {
                e.Row.Cells["FinancialAmount"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["FinancialAmount"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["Bill_Amount"].Value) > 0)
            {
                e.Row.Cells["Bill_Amount"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["Bill_Amount"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["TotalDisCount"].Value) > 0)
            {
                e.Row.Cells["TotalDisCount"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["TotalDisCount"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["TotalTax"].Value) > 0)
            {
                e.Row.Cells["TotalTax"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["TotalTax"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["BillWithTax"].Value) > 0)
            {
                e.Row.Cells["BillWithTax"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["BillWithTax"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DeliveryAmount"].Value) > 0)
            {
                e.Row.Cells["DeliveryAmount"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DeliveryAmount"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["Pay_Amount_Type_1"].Value) > 0)
            {
                e.Row.Cells["Pay_Amount_Type_1"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["Pay_Amount_Type_1"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["Pay_Amount_Type_2"].Value) > 0)
            {
                e.Row.Cells["Pay_Amount_Type_2"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["Pay_Amount_Type_2"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["Pay_Amount_Type_3"].Value) > 0)
            {
                e.Row.Cells["Pay_Amount_Type_3"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["Pay_Amount_Type_3"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["Pay_Amount"].Value) > 0)
            {
                e.Row.Cells["Pay_Amount"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["Pay_Amount"].FormatStyle = this.Negative;
            }
        }
    }
}
