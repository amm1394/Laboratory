using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class ShowDeliveryDateChangeForManager : RASF.General.Forms.Base.DockContentForm
    {
        public ShowDeliveryDateChangeForManager()
        {
            InitializeComponent();
           // this.ShowpnlSave = false;
            this.ShowpnlUpdate = false;
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
           // FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            FillGrid(e);
        }

        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.showDeliveryDateChangeForManagerList1.Fill(Parameter);

            grdDelivery.Refetch();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdDelivery.ExportToExcel("تغییر تاریخ تحویل");
        }
    }
}
