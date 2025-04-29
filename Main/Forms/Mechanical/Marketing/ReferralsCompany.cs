using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Marketing
{
    public partial class ReferralsCompany : RASF.General.Forms.Base.DockContentForm
    {
        private Janus.Windows.GridEX.GridEXFormatStyle ImportantFormat;
        public ReferralsCompany()
        {
            InitializeComponent();
          //  this.ShowpnlExit = false;

            this.ImportantFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.ImportantFormat.BackColor = Color.Goldenrod;
            this.ImportantFormat.ForeColor = Color.Black;
         
        }

        private void ReferralsCompany_Load(object sender, EventArgs e)
        {
            this.connectorOfCompaniesList1.Fill();


            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["MarketingExpert"], this.connectorOfCompaniesList1, "UserId", "UserName");
            this.grdCompany.RootTable.Columns["MarketingExpert"].DefaultValue = this.connectorOfCompaniesList1[1].UserId;
            
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

        private void grdCompany_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (Convert.ToBoolean(e.Row.Cells["ImportantCompany"].Value) == true)
            {
                e.Row.Cells["CompanyName"].FormatStyle = this.ImportantFormat;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.grdCompany.ExportToExcel("شرکت های بازاریابی");
        }
    }
}
