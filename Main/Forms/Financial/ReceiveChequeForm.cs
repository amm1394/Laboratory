using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class ReceiveChequeForm : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
        private Janus.Windows.GridEX.GridEXFormatStyle EtebariFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle DestructFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle RealRemindFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle FourtyPercentageOFCredit;

                public ReceiveChequeForm()
        {
            InitializeComponent();
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
            this.To = this.From = System.DateTime.Now;
            this.ShowpnlButton = false;

            this.EtebariFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.EtebariFormat.BackColor = Color.Orange;
            this.EtebariFormat.ForeColor = Color.Black;

            this.DestructFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.DestructFormat.BackColor = Color.Red;
            this.DestructFormat.ForeColor = Color.Black;

            this.RealRemindFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.RealRemindFormat.BackColor = Color.Green;
            this.RealRemindFormat.ForeColor = Color.Black;

            this.FourtyPercentageOFCredit = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.FourtyPercentageOFCredit.BackColor = Color.DarkOrange;
            this.FourtyPercentageOFCredit.ForeColor = Color.Black;

        }

        private void ReceiveChequeForm_Load(object sender, EventArgs e)
        {
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.receiveChequeList1.Fill(Parameters);
            this.grdCheque.Refetch();

            List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.receiveBankTransferList1.Fill(Parameters1);
            this.grdtransfer.Refetch();

            DateTime From = e.From;
            DateTime To = e.To;
        }

        private void btnSave_Click(object sender, EventArgs e)
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

            if (printDialog2.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog2.Document = gridEXPrintDocument2;
                printPreviewDialog2.ShowInTaskbar = true;
                printPreviewDialog2.MinimizeBox = true;
                printPreviewDialog2.PrintPreviewControl.Zoom = 1;
                printPreviewDialog2.WindowState = FormWindowState.Minimized;
                gridEXPrintDocument2.DefaultPageSettings.Landscape = true;
                gridEXPrintDocument2.PrinterSettings.PrinterName = printDialog2.PrinterSettings.PrinterName;
                gridEXPrintDocument2.PrinterSettings.Copies = printDialog2.PrinterSettings.Copies;
                gridEXPrintDocument2.Print();
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void grdCheque_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            string Contains1 = Convert.ToString(e.Row.Cells["CooperationName"].Value);
            if (Contains1.Contains( "اعتباری") )
            {
                e.Row.Cells["CompanyName"].FormatStyle = this.EtebariFormat;
                e.Row.Cells["CooperationName"].FormatStyle = this.EtebariFormat;

            
                  if (Convert.ToInt64(e.Row.Cells["Notinvoice"].Value) > Convert.ToInt64(e.Row.Cells["Credit"].Value))
                    {
                        if (Convert.ToInt64(e.Row.Cells["Notinvoice"].Value) <= Convert.ToInt64(e.Row.Cells["FourtyPercentageOFCredit"].Value))
                        {
                            e.Row.Cells["Notinvoice"].FormatStyle = this.FourtyPercentageOFCredit;
                        }
                        else
                        {
                            e.Row.Cells["Notinvoice"].FormatStyle = this.DestructFormat;
                        }
                    }
                    else
                    {
                        e.Row.Cells["Notinvoice"].FormatStyle = this.RealRemindFormat;
                    }
                

            }
        }

        private void grdtransfer_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            string Contains2 = Convert.ToString(e.Row.Cells["CooperationName"].Value);

            if (Contains2.Contains("اعتباری"))
            {
                e.Row.Cells["CompanyName"].FormatStyle = this.EtebariFormat;
                e.Row.Cells["CooperationName"].FormatStyle = this.EtebariFormat;

                if (Convert.ToInt64(e.Row.Cells["Notinvoice"].Value) > Convert.ToInt64(e.Row.Cells["Credit"].Value))
                {
                    e.Row.Cells["Notinvoice"].FormatStyle = this.DestructFormat;
                }
                else
                {
                    e.Row.Cells["Notinvoice"].FormatStyle = this.RealRemindFormat;
                }

            }
        }
    }
}
