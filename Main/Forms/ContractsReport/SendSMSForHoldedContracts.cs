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
    public partial class SendSMSForHoldedContracts : RASF.General.Forms.Base.DockContentForm
    {
        //private Janus.Windows.GridEX.GridEXFormatStyle TestFormat;
        //private Janus.Windows.GridEX.GridEXFormatStyle HoldFormat;
        //private Janus.Windows.GridEX.GridEXFormatStyle DestructFormat;
        //private Janus.Windows.GridEX.GridEXFormatStyle LaghvFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle NewCustomerFormat;

        public SendSMSForHoldedContracts()
        {
            InitializeComponent();
            this.deliveryDayForMagementList1.spName = "SendSMSForHoldedContracts";
         //   FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

            //this.TestFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            //this.TestFormat.BackColor = Color.Yellow;
            //this.TestFormat.ForeColor = Color.Black;

            //this.HoldFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            //this.HoldFormat.BackColor = Color.Bisque;
            //this.HoldFormat.ForeColor = Color.Black;

            //this.DestructFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            //this.DestructFormat.BackColor = Color.Red;
            //this.DestructFormat.ForeColor = Color.Black;

            //this.LaghvFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            //this.LaghvFormat.BackColor = Color.Firebrick;
            //this.LaghvFormat.ForeColor = Color.Black;

            this.NewCustomerFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.NewCustomerFormat.BackColor = Color.Plum;
            this.NewCustomerFormat.ForeColor = Color.Black;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdDelivery.ExportToExcel("کارهای تحویلی روز");
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            switch (e.Column.Key)
            {
                case "ContractNo":

                    RASF.General.Data.DeliveryDay CurrentRow = (RASF.General.Data.DeliveryDay)this.grdDelivery.CurrentRow.DataRow;
                    RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
                    CostPaper.Show();
                    break;
                case "IsHold":

                    RASF.General.Data.DeliveryDay CurrentRow2 = (RASF.General.Data.DeliveryDay)this.grdDelivery.CurrentRow.DataRow;
                    RASF.Main.Forms.Harmony.FollowUpIsHoldContractForView ViewReceiptDemandForm = new Harmony.FollowUpIsHoldContractForView(CurrentRow2.ContractsCode);
                    ViewReceiptDemandForm.Show();
                    break;
                case "CompanyName":
                    RASF.General.Data.DeliveryDay CurrentRow3 = (RASF.General.Data.DeliveryDay)this.grdDelivery.CurrentRow.DataRow;
                     List<System.Data.SqlClient.SqlParameter> Param = new List<System.Data.SqlClient.SqlParameter>();
                     Param.Add(new System.Data.SqlClient.SqlParameter("@ContractCode", CurrentRow3.ContractsCode));
                     Param.Add(new System.Data.SqlClient.SqlParameter("@MobileNo", this.grdDelivery.CurrentRow.Cells["MobileNo"].Value.ToString()));
                     Param.Add(new System.Data.SqlClient.SqlParameter("@ContractNo", CurrentRow3.ContractNo));
                     RASF.General.Lists.Base.BaseList<Object>.FillScalar("SendSMSForHoldedContracts_Insert", Param);
                     MessageBox.Show("پیام با موفقیت ارسال شد");
                    break;

            }

          
        }

     
        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
                         
          //  List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            this.deliveryDayForMagementList1.Fill();
            this.grdDelivery.Refetch();
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            FillGrid(e);
        }

        private void grdDelivery_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            //if (Convert.ToString(e.Row.Cells["DateOfTestForThePresence"].Value) != "")
            //{
            //    e.Row.Cells["DateOfTestForThePresence"].FormatStyle = this.TestFormat;
            //}

            //if (Convert.ToString(e.Row.Cells["IsHold"].Value) == "بله")
            //{
            //    e.Row.Cells["IsHold"].FormatStyle = this.HoldFormat;
            //}

            //if (Convert.ToString(e.Row.Cells["Destruct"].Value) != "")
            //{
            //    e.Row.Cells["Destruct"].FormatStyle = this.DestructFormat;
            //}

            //if (Convert.ToString(e.Row.Cells["Laghv"].Value) != "")
            //{
            //    e.Row.Cells["Laghv"].FormatStyle = this.LaghvFormat;
            //}

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
            this.deliveryDayForMagementList1.Fill();
            this.grdDelivery.Refetch();
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

        private void SendSMSForHoldedContracts_Load(object sender, EventArgs e)
        {
            this.deliveryDayForMagementList1.Fill();
            this.grdDelivery.Refetch();
        }
    }
}
