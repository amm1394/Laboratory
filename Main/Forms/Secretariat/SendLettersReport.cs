using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Secretariat
{
    public partial class SendLettersReport : RASF.General.Forms.Base.DockContentForm
    {
        public SendLettersReport()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.sendLettersReportList1.Fill(Parameter);
            this.grdReports.Refetch();

        }

        private void SendLettersReport_Load(object sender, EventArgs e)
        {
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdReports.ExportToExcel("نامه های ارسالی");
        }

        private void grdReports_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
           // ContractCode = (Guid)(this.grdReports.CurrentRow.Cells["SendLettersCode"].Value);
            RASF.Main.Forms.Secretariat.ShowSendLetters ShowSendLetters = new RASF.Main.Forms.Secretariat.ShowSendLetters((Guid)(this.grdReports.CurrentRow.Cells["SendLettersCode"].Value));
            ShowSendLetters.Show();
        }
    }
}
