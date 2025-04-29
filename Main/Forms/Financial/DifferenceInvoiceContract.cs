using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class DifferenceInvoiceContract : RASF.General.Forms.Base.DockContentForm
    {
        public DifferenceInvoiceContract()
        {
            InitializeComponent();
           
        }

        private void DifferenceInvoiceContract_Load(object sender, EventArgs e)
        {
            this.differenceInvoiceContractList1.Fill();
            this.grdDiffrence.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.differenceInvoiceContractList1.Fill();
            this.grdDiffrence.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdDiffrence.ExportToExcel("اختلاف مبالغ صورت حساب ها و قراردادها");
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
    }
}
