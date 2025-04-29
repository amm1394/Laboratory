using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.WorkFlow
{
    public partial class WorkFlowDescriptionReport : RASF.General.Forms.Base.DockContentForm
    {
        public WorkFlowDescriptionReport()
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
            this.workFlowDescriptionReportList1.Fill(Parameter);
            this.grdReports.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdReports.ExportToExcel("آزمون هایی که رد شده اند");
        }
    }
}
