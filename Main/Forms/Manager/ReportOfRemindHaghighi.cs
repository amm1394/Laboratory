using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class ReportOfRemindHaghighi : RASF.General.Forms.Base.DockContentForm
    {
        public ReportOfRemindHaghighi()
        {
            InitializeComponent();
            FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            FillGrid(e);
        }

        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@To", e.To));
            this.reportOfRemindHaghighiList1.Fill(Parameter);
            this.grid1.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grid1.ExportToExcel("");
        }

        private void grid1_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.ReportOfRemindHaghighi CurrentRow = (RASF.General.Data.ReportOfRemindHaghighi)this.grid1.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }
    }
}
