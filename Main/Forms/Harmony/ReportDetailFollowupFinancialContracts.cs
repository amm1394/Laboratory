using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class ReportDetailFollowupFinancialContracts : RASF.General.Forms.Base.DockContentForm
    {
        private Guid ContractsCode;
        public ReportDetailFollowupFinancialContracts(Guid ContractCode)
        {
            InitializeComponent();
            this.ShowpnlButton = false;
            ContractsCode = ContractCode;
        }

        private void ReportDetailFollowupFinancialContracts_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", ContractsCode));
            this.reportDetailFollowupFinancialContractsList1.Fill(Parameter1);
            this.grdReports.Refetch();
        }

        private void grdReports_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdReports.CurrentRow != null) && (this.grdReports.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.groupBox1.Text = "قرارداد" + " " + this.grdReports.CurrentRow.Cells["ContractNo"].Value.ToString() + "سال مالی" + "    " + this.grdReports.CurrentRow.Cells["ContractYear"].Value.ToString();
            }
            else
            {
                this.groupBox1.Text = "";
            }
        }
    }
}
