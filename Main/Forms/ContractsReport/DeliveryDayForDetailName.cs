using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.ContractsReport
{
    public partial class DeliveryDayForDetailName : RASF.General.Forms.Base.DockContentForm
    {
        public DeliveryDayForDetailName()
        {
            InitializeComponent();
            this.deliveryDayList1.spName = "DeliveryDayForDetailName";
            FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdDelivery.ExportToExcel("کارهای تحویلی روز");
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.DeliveryDay CurrentRow = (RASF.General.Data.DeliveryDay)this.grdDelivery.CurrentRow.DataRow;
            RASF.Main.Forms.Laboratory.ViewCostPaperLaboratory CostPaper = new Laboratory.ViewCostPaperLaboratory(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }

     
        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.deliveryDayList1.Fill(Parameter);

            grdDelivery.Refetch();
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            FillGrid(e);
        }

        private void grdDelivery_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog1.Document = gridEXPrintDocument1;
                printPreviewDialog1.ShowInTaskbar = true;
                printPreviewDialog1.MaximizeBox = true;
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.WindowState = FormWindowState.Maximized;
                gridEXPrintDocument1.DefaultPageSettings.Landscape = true;
                gridEXPrintDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(10,10,60,10);
                gridEXPrintDocument1.PrinterSettings.PrinterName = printDialog1.PrinterSettings.PrinterName;
                gridEXPrintDocument1.PrinterSettings.Copies = printDialog1.PrinterSettings.Copies;
                gridEXPrintDocument1.Print();
            }
        }
    }
}
