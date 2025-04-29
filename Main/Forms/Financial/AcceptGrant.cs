using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class AcceptGrant : RASF.General.Forms.Base.DockContentForm
    {
        public AcceptGrant()
        {
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
            InitializeComponent();
        }

        private void AcceptGrant_Load(object sender, EventArgs e)
        {
            this.yes_NoList1.Fill();
            General.Classes.Utility.Create_DropDown(this.grdContracts.RootTable.Columns["Grant"], this.yes_NoList1, "Code", "YesNo");
            this.grdContracts.RootTable.Columns["Grant"].DefaultValue = this.yes_NoList1[0].Code;

            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@FinancialYear", RASF.General.Classes.Global.FinancialYear));
            this.acceptGrantList1.Fill(Parameters);
            this.grdContracts.Refetch();
      }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            foreach (RASF.General.Data.AcceptGrant rowUser in acceptGrantList1)
            {
                rowUser.UserId = RASF.General.Classes.Global.CurrentUserCode;
            }

            ((RASF.General.Data.AcceptGrant)this.grdContracts.SelectedItems[0].GetRow().DataRow).RowState = General.Enums.RowState.Updated;
            this.acceptGrantList1.Update();
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@FinancialYear", RASF.General.Classes.Global.FinancialYear));
            this.acceptGrantList1.Fill(Parameters);
            this.grdContracts.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@FinancialYear", RASF.General.Classes.Global.FinancialYear));
            this.acceptGrantList1.Fill(Parameters);
            this.grdContracts.Refetch();
        }
    }
}
