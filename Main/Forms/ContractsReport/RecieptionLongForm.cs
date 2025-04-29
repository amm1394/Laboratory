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
    public partial class RecieptionLongForm : RASF.General.Forms.Base.DockContentForm
    {
        private Janus.Windows.GridEX.GridEXFormatStyle TestFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle HoldFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle DestructFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle AmalkardFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle KhordeghiFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle MicroscopFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle TakhribFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle ValidFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle LaghvFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle NewCustomerFormat;
        public RecieptionLongForm()
        {
            InitializeComponent();
            this.TestFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.TestFormat.BackColor = Color.Yellow;
            this.TestFormat.ForeColor = Color.Black;

            this.HoldFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.HoldFormat.BackColor = Color.Bisque;
            this.HoldFormat.ForeColor = Color.Black;

            this.DestructFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.DestructFormat.BackColor = Color.Red;
            this.DestructFormat.ForeColor = Color.Black;

            this.AmalkardFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.AmalkardFormat.BackColor = Color.Chartreuse;
            this.AmalkardFormat.ForeColor = Color.Black;

            this.KhordeghiFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.KhordeghiFormat.BackColor = Color.Blue;
            this.KhordeghiFormat.ForeColor = Color.Black;

            this.MicroscopFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.MicroscopFormat.BackColor = Color.BlueViolet;
            this.MicroscopFormat.ForeColor = Color.Black;

            this.TakhribFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.TakhribFormat.BackColor = Color.CornflowerBlue;
            this.TakhribFormat.ForeColor = Color.Black;

            this.ValidFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.ValidFormat.BackColor = Color.YellowGreen;
            this.ValidFormat.ForeColor = Color.Black;

            this.LaghvFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.LaghvFormat.BackColor = Color.Firebrick;
            this.LaghvFormat.ForeColor = Color.Black;

            this.NewCustomerFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.NewCustomerFormat.BackColor = Color.Plum;
            this.NewCustomerFormat.ForeColor = Color.Black;

            FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("");
            grdRecieptionLongTest.ExportToExcel("پذیرش طولانی مسئله دار");
            this.grdRecieptionLong.ExportToExcel("پذیرش طولانی");
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.DeliveryDay CurrentRow = (RASF.General.Data.DeliveryDay)this.grdRecieptionLongTest.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }
        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
                         
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            this.recieptionLongList1.Fill(Parameter);
            this.grdRecieptionLongTest.Refetch();
        }
        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            FillGrid(e);
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
           this.recieptionLongList1.Fill();
            this.grdRecieptionLong.Refetch();

            this.recieptionLongIsHoldTestList1.Fill();
            this.grdRecieptionLongTest.Refetch();
        }

        private void RecieptionLongForm_Load(object sender, EventArgs e)
        {
            this.label8.BackColor = Color.Chartreuse;
            this.label9.BackColor = Color.BlueViolet;
            this.label10.BackColor = Color.Blue;
            this.label11.BackColor = Color.CornflowerBlue;
           
            this.recieptionLongList1.Fill();
            this.grdRecieptionLongTest.Refetch();

            this.recieptionLongIsHoldTestList1.Fill();
            this.grdRecieptionLongTest.Refetch();

        }
      
     

        private void grdRecieptionLong_FormattingRow(object sender, RowLoadEventArgs e)
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


            if (Convert.ToBoolean(e.Row.Cells["Valid"].Value) == true && Convert.ToString(e.Row.Cells["DescLongRec"].Value) != "")
            {
                e.Row.Cells["DescLongRec"].FormatStyle = this.ValidFormat;
            }

            if (Convert.ToString(e.Row.Cells["DateOFCancelToExit"].Value) != "")
            {
                e.Row.Cells["DateOFCancelToExit"].FormatStyle = this.LaghvFormat;
            }

            string Master = Convert.ToString(e.Row.Cells["LaboratoryName"].Value);
            if (Master.Contains("عملکرد"))
            {
                e.Row.Cells["LaboratoryName"].FormatStyle = this.AmalkardFormat;
            }

            if (Master.Contains("خوردگی"))
            {
                e.Row.Cells["LaboratoryName"].FormatStyle = this.KhordeghiFormat;
            }

            if (Master.Contains("مطالعات و بررسی علت تخریب"))
            {
                e.Row.Cells["LaboratoryName"].FormatStyle = this.TakhribFormat;
            }

            if (Master.Contains("میکروسکوپ الکترونی"))
            {
                e.Row.Cells["LaboratoryName"].FormatStyle = this.MicroscopFormat;
            }

            if (Convert.ToInt16(e.Row.Cells["Morajeat"].Value) <= 10 && Convert.ToInt16(e.Row.Cells["Morajeat"].Value) > 0)
            {
                e.Row.Cells["CompanyName"].FormatStyle = this.NewCustomerFormat;
            }
        }
        private void grdRecieptionLongTest_FormattingRow(object sender, RowLoadEventArgs e)
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

            if (Convert.ToBoolean(e.Row.Cells["Valid"].Value) == true && Convert.ToString(e.Row.Cells["DescLongRec"].Value) != "")
            {
                e.Row.Cells["DescLongRec"].FormatStyle = this.ValidFormat;
            }

            if (Convert.ToString(e.Row.Cells["DateOFCancelToExit"].Value) != "")
            {
                e.Row.Cells["DateOFCancelToExit"].FormatStyle = this.LaghvFormat;
            }

            string Master = Convert.ToString(e.Row.Cells["LaboratoryName"].Value);
            if (Master.Contains("عملکرد"))
            {
                e.Row.Cells["LaboratoryName"].FormatStyle = this.AmalkardFormat;
            }

            if (Master.Contains("خوردگی"))
            {
                e.Row.Cells["LaboratoryName"].FormatStyle = this.KhordeghiFormat;
            }

            if (Master.Contains("مطالعات و بررسی علت تخریب"))
            {
                e.Row.Cells["LaboratoryName"].FormatStyle = this.TakhribFormat;
            }

            if (Master.Contains("میکروسکوپ الکترونی"))
            {
                e.Row.Cells["LaboratoryName"].FormatStyle = this.MicroscopFormat;
            }

            if (Convert.ToInt16(e.Row.Cells["Morajeat"].Value) <= 10 && Convert.ToInt16(e.Row.Cells["Morajeat"].Value) > 0)
            {
                e.Row.Cells["CompanyName"].FormatStyle = this.NewCustomerFormat;
            }
        }

        private void grdRecieptionLongTest_LoadingRow(object sender, RowLoadEventArgs e)
        {
          
        }

       

      
    }
}
