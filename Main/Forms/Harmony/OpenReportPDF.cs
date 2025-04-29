using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class OpenReportPDF : RASF.General.Forms.Base.DockContentForm
    {


        public OpenReportPDF()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
            this.openReportList1.spName = "OpenReportPDF";
        }
        RASF.General.Data.ObservationReport ObservationReport = new General.Data.ObservationReport();

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            if (String.IsNullOrWhiteSpace(this.txtSearch.Text) == false)
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractNo", this.txtSearch.Text));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
                this.findContractNoList1.Fill(Parameter);

                List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoList1[0].ContractsCode));
                Parameter1.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
                this.openReportList1.Fill(Parameter1);
                this.grdView.Refetch();
            }
        }

        private void grdView_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (textBox1.Text != "")
            {
                RASF.General.Data.ObservationReport Current_Contract1 = (RASF.General.Data.ObservationReport)this.grdView.SelectedItems[0].GetRow().DataRow;
                ((RASF.General.Data.ObservationReport)this.grdView.SelectedItems[0].GetRow().DataRow).RowState = General.Enums.RowState.Updated;
                this.openReportList1.Update();

                List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoList1[0].ContractsCode));
                Parameter1.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
                this.openReportList1.Fill(Parameter1);
                this.grdView.Refetch();

                List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", Current_Contract1.PartsTestMasterCode));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserID", RASF.General.Classes.Global.CurrentUserCode));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@RType", Current_Contract1.RType));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserRequest", textBox1.Text));
                RASF.General.Lists.BanksList.FillScalar("OpenReportRequest_Insert", Parameters);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
