using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class Thefunctionoftheentirecompany : RASF.General.Forms.Base.DockContentForm
    {
        public Thefunctionoftheentirecompany()
        {
            InitializeComponent();
            this.ShowpnlUpdate = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdCompany.ExportToExcel("");
        }

        private void Thefunctionoftheentirecompany_Load(object sender, EventArgs e)
        {
            this.thefunctionoftheentirecompanyList1.Fill();
            this.grdCompany.Refetch();
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
