using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reports
{
    public partial class RedactForm : RASF.General.Forms.Base.DockContentForm
    {
        private Janus.Windows.GridEX.GridEXFormatStyle EnglishReport;
        public RedactForm()
        {
            InitializeComponent();
            pnlSave.Enabled = false;
            pnlExit.Enabled = false;


            this.EnglishReport = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.EnglishReport.BackColor = Color.Red;
            this.EnglishReport.ForeColor = Color.Black;

        }

        private void RedactForm_Load(object sender, EventArgs e)
        {
            //List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            //Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.redactList1.Fill();
            this.grdRedact.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            //Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.redactList1.Fill();
            this.grdRedact.Refetch();
        }

        private void grdRedact_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (Convert.ToString(e.Row.Cells["EnglishReporter"].Value) == "دارد")
            {
                e.Row.Cells["EnglishReporter"].FormatStyle = this.EnglishReport;
            }
        }
    }
}
