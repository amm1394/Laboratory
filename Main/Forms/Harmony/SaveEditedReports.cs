using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class SaveEditedReports : RASF.General.Forms.Base.DockContentForm
    {
        private Guid ContractCode;
        public SaveEditedReports(Guid ContractCode)
        {
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
            InitializeComponent();
            this.ContractCode = ContractCode;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.letter_Scan1.Document != null)
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractCode));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("EditedReport", this.letter_Scan1.Document));
                RASF.General.Lists.Base.BaseList<Object>.FillScalar("SaveEditedReport_Insert", Parameter);

            }
            this.Close();
        }

        private void SaveCostPaper_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.letter_Scan1.Dispose();
        }

        private void SaveEditedReports_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractCode));
            this.showEditedReportList1.Fill(Parameter1);
            if (this.showEditedReportList1.list.Count > 0)
            {
                this.letter_Scan1.Document = this.showEditedReportList1.list[0].EditedReport;
            }
        }
    }
}
