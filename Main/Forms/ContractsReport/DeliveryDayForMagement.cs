using Janus.Windows.GridEX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.ContractsReport
{
    public partial class DeliveryDayForMagement : RASF.General.Forms.Base.DockContentForm
    {
        private Janus.Windows.GridEX.GridEXFormatStyle TestFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle HoldFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle DestructFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle LaghvFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle NewCustomerFormat;

        public DeliveryDayForMagement()
        {
            InitializeComponent();

            this.deliveryDayForMagementList1.spName = "Holded_Contracts_Report";
            this.deliveryDayForMagementList2.spName = "Delayed_Contracts_Report";

        //    FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

            this.TestFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.TestFormat.BackColor = Color.Yellow;
            this.TestFormat.ForeColor = Color.Black;

            this.HoldFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.HoldFormat.BackColor = Color.Bisque;
            this.HoldFormat.ForeColor = Color.Black;

            this.DestructFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.DestructFormat.BackColor = Color.Red;
            this.DestructFormat.ForeColor = Color.Black;

            this.LaghvFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.LaghvFormat.BackColor = Color.Firebrick;
            this.LaghvFormat.ForeColor = Color.Black;

            this.NewCustomerFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.NewCustomerFormat.BackColor = Color.Plum;
            this.NewCustomerFormat.ForeColor = Color.Black;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdHold.ExportToExcel("کارهای مساله دار");
            this.grdDelay.ExportToExcel("کارهای تاخیری");
        }

     
        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {

            this.deliveryDayForMagementList1.Fill();
            this.grdHold.Refetch();

            this.deliveryDayForMagementList2.Fill();
            this.grdDelay.Refetch();
        }

  

        private void grdDelivery_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (Convert.ToString(e.Row.Cells["DateOfTestForThePresence"].Value) != "")
            {
                e.Row.Cells["DateOfTestForThePresence"].FormatStyle = this.TestFormat;
            }

            if (Convert.ToString(e.Row.Cells["IsHold"].Value) == "بله")
            {
                e.Row.Cells["IsHold"].FormatStyle = this.HoldFormat;
            }

            if (Convert.ToString(e.Row.Cells["Destruct"].Value) != "")
            {
                e.Row.Cells["Destruct"].FormatStyle = this.DestructFormat;
            }

            if (Convert.ToString(e.Row.Cells["Laghv"].Value) != "")
            {
                e.Row.Cells["Laghv"].FormatStyle = this.LaghvFormat;
            }

            if (Convert.ToInt16(e.Row.Cells["Morajeat"].Value) <= 10 && Convert.ToInt16(e.Row.Cells["Morajeat"].Value) > 0)
            {
                e.Row.Cells["CompanyName"].FormatStyle = this.NewCustomerFormat;
            }
            
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            this.deliveryDayForMagementList1.Fill();
            this.grdHold.Refetch();

            this.deliveryDayForMagementList2.Fill();
            this.grdDelay.Refetch();
        }

        private void grdDelivery_LoadingRow(object sender, RowLoadEventArgs e)
        {
            //for (int i = 0; i < grdDelivery.RowCount; i++)
            //{

            //    if (e.Row.Cells["Destruct"].Value.ToString() != "")
            //    {

            //        if (e.Row.RowType == Janus.Windows.GridEX.RowType.Record)
            //        {
            //            Janus.Windows.GridEX.GridEXFormatStyle rowcol = new GridEXFormatStyle();
            //            rowcol.BackColor = Color.Red;
            //            e.Row.RowStyle = rowcol;
            //        }
            //    }
            //}
        }

        private void DeliveryDayForMagement_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void grdDelay_FormattingRow(object sender, RowLoadEventArgs e)
        {
            if (Convert.ToString(e.Row.Cells["DateOfTestForThePresence"].Value) != "")
            {
                e.Row.Cells["DateOfTestForThePresence"].FormatStyle = this.TestFormat;
            }

            //if (Convert.ToString(e.Row.Cells["IsHold"].Value) == "بله")
            //{
            //    e.Row.Cells["IsHold"].FormatStyle = this.HoldFormat;
            //}

            if (Convert.ToString(e.Row.Cells["Destruct"].Value) != "")
            {
                e.Row.Cells["Destruct"].FormatStyle = this.DestructFormat;
            }

            if (Convert.ToString(e.Row.Cells["Laghv"].Value) != "")
            {
                e.Row.Cells["Laghv"].FormatStyle = this.LaghvFormat;
            }

            if (Convert.ToInt16(e.Row.Cells["Morajeat"].Value) <= 10 && Convert.ToInt16(e.Row.Cells["Morajeat"].Value) > 0)
            {
                e.Row.Cells["CompanyName"].FormatStyle = this.NewCustomerFormat;
            }
        }

        private void grdHold_ColumnButtonClick(object sender, ColumnActionEventArgs e)
        {
            switch (e.Column.Key)
            {
                case "ContractNo":

                    RASF.General.Data.DeliveryDay CurrentRow = (RASF.General.Data.DeliveryDay)this.grdHold.CurrentRow.DataRow;
                    RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
                    CostPaper.Show();

                    break;

                case "IsHold":

                    RASF.General.Data.DeliveryDay CurrentRow2 = (RASF.General.Data.DeliveryDay)this.grdHold.CurrentRow.DataRow;
                    RASF.Main.Forms.Harmony.FollowUpIsHoldContractForView ViewReceiptDemandForm = new Harmony.FollowUpIsHoldContractForView(CurrentRow2.ContractsCode);
                    ViewReceiptDemandForm.Show();

                    break;
            }
        }

        private void grdDelay_ColumnButtonClick(object sender, ColumnActionEventArgs e)
        {
            switch (e.Column.Key)
            {
                case "ContractNo":

                    RASF.General.Data.DeliveryDay CurrentRowD = (RASF.General.Data.DeliveryDay)this.grdDelay.CurrentRow.DataRow;
                    RASF.Main.Forms.Harmony.ViewCostPaper CostPaperD = new Harmony.ViewCostPaper(CurrentRowD.ContractsCode, CurrentRowD.ContractNo);
                    CostPaperD.Show();
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog2.Document = gridEXPrintDocument1;
                printPreviewDialog2.ShowInTaskbar = true;
                printPreviewDialog2.MinimizeBox = true;
                printPreviewDialog2.PrintPreviewControl.Zoom = 1;
                printPreviewDialog2.WindowState = FormWindowState.Minimized;
                gridEXPrintDocument2.DefaultPageSettings.Landscape = true;
                gridEXPrintDocument2.PrinterSettings.PrinterName = printDialog1.PrinterSettings.PrinterName;
                gridEXPrintDocument2.PrinterSettings.Copies = printDialog1.PrinterSettings.Copies;
                gridEXPrintDocument2.Print();
            }
        }
    }
}
