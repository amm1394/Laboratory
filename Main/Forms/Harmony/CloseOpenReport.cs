using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class CloseOpenReport : RASF.General.Forms.Base.DockContentForm
    {


        public CloseOpenReport()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
        }
        //RASF.General.Data.ObservationReport ObservationReport = new General.Data.ObservationReport();

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
           
        //    if (String.IsNullOrWhiteSpace(this.txtSearch.Text) == false)
        //    {
        //        List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
        //        Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractNo", this.txtSearch.Text));
        //        Parameter.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
        //        this.findContractNoList1.Fill(Parameter);

        //        List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
        //        Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoList1[0].ContractsCode));
        //        this.openReportList1.Fill(Parameter1);
        //        this.grdView.Refetch();
        //    }
        //}

        private void grdView_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {

            RASF.General.Data.ObservationReport Current_Contract1 = (RASF.General.Data.ObservationReport)this.grdView.SelectedItems[0].GetRow().DataRow;
            ((RASF.General.Data.ObservationReport)this.grdView.SelectedItems[0].GetRow().DataRow).RowState = General.Enums.RowState.Updated;
            this.closeOpenReportList1.Update();

            this.closeOpenReportList1.Fill();
            this.grdView.Refetch();
        }

        private void CloseOpenReport_Load(object sender, EventArgs e)
        {
            this.closeOpenReportList1.Fill();
            this.grdView.Refetch();
        }
    }
}
