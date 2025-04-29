using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Base
{
    [System.ComponentModel.Category("RASF")]
    public partial class CompaniesConector : RASF.General.Forms.Base.DockContentForm
    {
        public CompaniesConector()
        {
            InitializeComponent();
           
        }

        
        private void COMPANIES_BASE_Load(object sender, EventArgs e)
        {
            
            this.companiesBaseList1.Fill();
            this.grdCompanyBase.Refetch();

            this.companiesConectorList1.Fill();
            this.grdConnector.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

                    this.companiesConectorList1.Update();

                    this.companiesConectorList1.Fill();
                    this.grdConnector.Refetch();
        }

        private void grdCompanyBase_SelectionChanged(object sender, EventArgs e)
        {

            RASF.General.Data.Companies_Base Current_Company = (RASF.General.Data.Companies_Base)this.grdCompanyBase.SelectedItems[0].GetRow().DataRow;
            if (Current_Company != null)
            {
                this.grpCompanies.Text = "شرکت" + " " + this.grdCompanyBase.CurrentRow.Cells["CompanyName"].Value.ToString();
                this.grpConnector.Text = "اطلاعات رابطین شرکت" + " " + this.grdCompanyBase.CurrentRow.Cells["CompanyName"].Value.ToString();
            }
        }

        private void grdCompanyBase_SelectionChanged_1(object sender, EventArgs e)
        {
            if ((this.grdCompanyBase.CurrentRow != null) && (this.grdCompanyBase.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpCompanies.Text = this.grdCompanyBase.CurrentRow.Cells["CompanyName"].Value.ToString();
                this.grdConnector.RootTable.Columns["CompaniesCode"].DefaultValue = this.grdCompanyBase.CurrentRow.Cells["CompaniesCode"].Value;
                this.grdConnector.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdConnector.RootTable.Columns["CompaniesCode"], Janus.Windows.GridEX.ConditionOperator.Equal, this.grdCompanyBase.CurrentRow.Cells["CompaniesCode"].Value));
                this.grdConnector.Enabled = true;
            }
            else
            {
                this.grpCompanies.Text = "";
                this.grdConnector.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdConnector.RootTable.Columns["CompaniesCode"], Janus.Windows.GridEX.ConditionOperator.Equal, Guid.NewGuid()));
               
            }
            this.grdConnector.MoveFirst();
        }
    }
}
