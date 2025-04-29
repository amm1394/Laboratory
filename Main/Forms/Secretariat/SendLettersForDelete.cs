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
    public partial class SendLettersForDelete : RASF.General.Forms.Base.DockContentForm
    {
        public SendLettersForDelete()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
            this.sendLettersReportList1.spName = "SendLettersForDelete";
        }

        private void SendLettersReport_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
            this.sendLettersReportList1.Fill(Parameter);
            this.grdReports.Refetch();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdReports.ExportToExcel("نامه های ارسالی");
        }

        private void grdReports_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            switch (e.Column.Key)
            {
                case "CompanyLetterNo":
                    RASF.General.Data.SendLetters SendLetters = (RASF.General.Data.SendLetters)this.grdReports.CurrentRow.DataRow;
                    SendLetters.RowState = General.Enums.RowState.Updated;
                    this.sendLettersReportList1.Update();
                    MessageBox.Show("نامه مورد نظر حذف شد");
                    break;
                case "SubjectOfLetters":
                     RASF.Main.Forms.Secretariat.ShowSendLetters ShowSendLetters = new RASF.Main.Forms.Secretariat.ShowSendLetters((Guid)(this.grdReports.CurrentRow.Cells["SendLettersCode"].Value));
                     ShowSendLetters.Show();
                    break;

            }
              
        }
    }
}
