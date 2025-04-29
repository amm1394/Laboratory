using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.SEM
{
    public partial class ReportOfSem : RASF.General.Forms.Base.DockContentForm
    {
        private Janus.Windows.GridEX.GridEXFormatStyle InPersonFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle NoCustomerPresenceFormat;
        public ReportOfSem()
        {
            InitializeComponent();
            this.ShowpnlExit = false;

            this.InPersonFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.InPersonFormat.BackColor = Color.Blue;
            this.InPersonFormat.ForeColor = Color.Black;

            this.NoCustomerPresenceFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.NoCustomerPresenceFormat.BackColor = Color.Red;
            this.NoCustomerPresenceFormat.ForeColor = Color.Black;
        }

        private void ReportOfSem_Load(object sender, EventArgs e)
        {
            this.reportOfSemList1.Fill();
            this.grdReports.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdReports.ExportToExcel("SEM");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.reportOfSemList1.Fill();
            this.grdReports.Refetch();
        }

        private void grdReports_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (Convert.ToString(e.Row.Cells["StringInPerson"].Value) !=  "")
            {
                e.Row.Cells["StringInPerson"].FormatStyle = this.InPersonFormat;
            }

            if (Convert.ToString(e.Row.Cells["StrNoCustomerPresence"].Value) != "")
            {
                e.Row.Cells["StrNoCustomerPresence"].FormatStyle = this.NoCustomerPresenceFormat;
            }
        }
    }
}
