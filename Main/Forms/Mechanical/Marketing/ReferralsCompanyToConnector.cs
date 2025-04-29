using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Marketing
{
    public partial class ReferralsCompanyToConnector : RASF.General.Forms.Base.DockContentForm
    {
        public ReferralsCompanyToConnector()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.referralsCompanyList1.spName = "ReferralsCompanyToConnector";
         
        }

        private void ReferralsCompany_Load(object sender, EventArgs e)
        {
            this.connectorOfCompaniesList1.Fill();
            this.yes_NoList1.Fill();

            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["ConnectorId"], this.connectorOfCompaniesList1, "UserId", "UserName");
            this.grdCompany.RootTable.Columns["ConnectorId"].DefaultValue = this.connectorOfCompaniesList1[1].UserId;

            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["Messenger"], this.yes_NoList1, "Code", "YesNo");
            
          //  this.grdCompany.RemoveBindingContextChanged();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            this.referralsCompanyList1.Fill();
            this.grdCompany.Refetch();
        }

        private void grdCompany_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            //if (this.grdCompany.SelectedItems.Count >0)
            //{
            //    RASF.General.Data.Companies_Base CurrentRow = (RASF.General.Data.Companies_Base)this.grdCompany.SelectedItems[0].GetRow().DataRow;
            //    CurrentRow.RowState = General.Enums.RowState.Updated;
            //    referralsCompanyList1.Update();
            //}
            //this.referralsCompanyList1.Fill();
            //this.grdCompany.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.referralsCompanyList1.Update();

            RefreshGrid();
        }
    }
}
