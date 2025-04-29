using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Laboratory
{
    public partial class CancelEnterLaboratory : RASF.General.Forms.Base.DockContentForm
    {
        public CancelEnterLaboratory()
        {
            InitializeComponent();
        }

        private void CancelEnterLaboratory_Load(object sender, EventArgs e)
        {
            //List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            //Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            //this.cancelEnterLaboratoryList1.Fill(Parameter);
            //this.grdEnterContract.Refetch();
        }

        private void grdEnterContract_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            //if (this.grdEnterContract.SelectedItems.Count > 0)
            //{
            //    RASF.General.Data.DeliveryDay CurrentRow = (RASF.General.Data.DeliveryDay)this.grdEnterContract.SelectedItems[0].GetRow().DataRow;
            //    CurrentRow.RowState = General.Enums.RowState.Updated;
            //    this.cancelEnterLaboratoryList1.Update();
            //}
        }

        private void searchContractcsForAll1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@ContractCode", e.ContractsCode));
            this.cancelEnterLaboratoryList1.Fill(Parameter);
            this.grdEnterMaster.Refetch();
        }

        private void grdEnterMaster_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (this.grdEnterMaster.SelectedItems.Count > 0)
            {
                RASF.General.Data.CancelEnterMaster CurrentRow = (RASF.General.Data.CancelEnterMaster)this.grdEnterMaster.SelectedItems[0].GetRow().DataRow;
                CurrentRow.RowState = General.Enums.RowState.Updated;
                this.cancelEnterLaboratoryList1.Update();
            }
        }

        private void searchContractcsForAll2_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@ContractCode", e.ContractsCode));
            this.cancelExitLaboratoryList1.Fill(Parameter);
            this.grdExitMaster.Refetch();
        }

        private void grdExitMaster_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (this.grdExitMaster.SelectedItems.Count > 0)
            {
                RASF.General.Data.CancelEnterMaster CurrentRow = (RASF.General.Data.CancelEnterMaster)this.grdExitMaster.SelectedItems[0].GetRow().DataRow;
                CurrentRow.RowState = General.Enums.RowState.Updated;
                this.cancelExitLaboratoryList1.Update();
            }
        }

        private void searchContractcsForAll3_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@ContractCode", e.ContractsCode));
            this.cancelEnterScienceList1.Fill(Parameter);
            this.grdEnterScience.Refetch();
        }

        private void grdEnterScience_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (this.grdEnterScience.SelectedItems.Count > 0)
            {
                RASF.General.Data.CancelEnterMaster CurrentRow = (RASF.General.Data.CancelEnterMaster)this.grdEnterScience.SelectedItems[0].GetRow().DataRow;
                CurrentRow.Description = this.txtReason.Text;
                CurrentRow.UserName = General.Classes.Global.CurrentUserName;
                CurrentRow.RowState = General.Enums.RowState.Updated;
                this.cancelEnterScienceList1.Update();
                this.txtReason.Text = "";
            }
        }

        private void searchContractcsForAll4_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@ContractCode", e.ContractsCode));
            this.cancelExitScienceList1.Fill(Parameter);
            this.grdExitScience.Refetch();
        }

        private void grdExitScience_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (this.grdExitScience.SelectedItems.Count > 0)
            {
                RASF.General.Data.CancelEnterMaster CurrentRow = (RASF.General.Data.CancelEnterMaster)this.grdExitScience.SelectedItems[0].GetRow().DataRow;
                CurrentRow.Description = this.txtReason.Text;
                CurrentRow.UserName = General.Classes.Global.CurrentUserName;
                CurrentRow.RowState = General.Enums.RowState.Updated;
                this.cancelExitScienceList1.Update();
                this.txtReason.Text = "";
            }
        }

        private void grdEnterScience_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }

        private void grpText_Click(object sender, EventArgs e)
        {

        }
    }
}
