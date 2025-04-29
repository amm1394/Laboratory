using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace RASF.Main.Forms.Marketing
{
    public partial class SummaryofCompaniesstatus : RASF.General.Forms.Base.DockContentForm
    {
        private Guid CoId;
        private Janus.Windows.GridEX.GridEXFormatStyle ImportantFormat;
        public SummaryofCompaniesstatus()
        {
            InitializeComponent();
            this.companies_BaseMarketingList1.spName = "SummeryOfCompaniesMarketing";

            this.ImportantFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.ImportantFormat.BackColor = Color.Goldenrod;
            this.ImportantFormat.ForeColor = Color.Black;
        }

        private void grdShow_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text = (string)this.grdShow.CurrentRow.Cells["Description"].Value;
        }

        private void SummaryofCompaniesstatus_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> parameter = new List<System.Data.SqlClient.SqlParameter>();
            parameter.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.companies_BaseMarketingList1.Fill(parameter);
            this.grdCompanies.Refetch();

            this.companiesEmailList1.Fill();
            this.companiesPhoneNumList1.Fill();
            this.companiesFaxNumList1.Fill();
            this.companies_MobileNumList1.Fill();
            this.companies_PeopleRelatedList1.Fill();
         //   this.statusOfMarketingList1.Fill();

            this.grdEmail.Refetch();
            this.grdFax.Refetch();
            this.grdPhone.Refetch();
            this.grdMobile.Refetch();
            this.grdRelated.Refetch();
        //   this.grdStatus.Refetch();

            this.grdEmail.RemoveBindingContextChanged();
            this.grdFax.RemoveBindingContextChanged();
            this.grdPhone.RemoveBindingContextChanged();
            this.grdMobile.RemoveBindingContextChanged();
            this.grdRelated.RemoveBindingContextChanged();
       //     this.grdStatus.RemoveBindingContextChanged();

            //this.grdCompanies.SelectionChanged += new System.EventHandler(this.grdCompanies_SelectionChanged);
            this.grdCompanies_SelectionChanged(sender, e);
            
        }

        private void grdCompanies_SelectionChanged(object sender, EventArgs e)
        {

            RASF.General.Data.Companies_Base Current_Company = (RASF.General.Data.Companies_Base)this.grdCompanies.SelectedItems[0].GetRow().DataRow;

            if (this.grdCompanies.SelectedItems[0].Position > -1)
            {
                CoId = ((RASF.General.Data.Companies_Base)grdCompanies.CurrentRow.DataRow).CompaniesCode;

            }
            else
            {
                CoId = new Guid();

            }
            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("CompaniesCode", CoId));
            this.statusOfMarketingList1.Fill(Parameter1);
            this.grdStatus.Refetch();

            this.grdPhone.RootTable.Columns["CompanyCode"].DefaultValue = CoId;
            this.grdPhone.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdPhone.RootTable.Columns["CompanyCode"], Janus.Windows.GridEX.ConditionOperator.Equal, CoId));

            this.grdFax.RootTable.Columns["CompanyCode"].DefaultValue = CoId;
            this.grdFax.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdFax.RootTable.Columns["CompanyCode"], Janus.Windows.GridEX.ConditionOperator.Equal, CoId));

            this.grdEmail.RootTable.Columns["CompanyCode"].DefaultValue = CoId;
            this.grdEmail.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdEmail.RootTable.Columns["CompanyCode"], Janus.Windows.GridEX.ConditionOperator.Equal, CoId));

            this.grdMobile.RootTable.Columns["CompanyCode"].DefaultValue = CoId;
            this.grdMobile.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdMobile.RootTable.Columns["CompanyCode"], Janus.Windows.GridEX.ConditionOperator.Equal, CoId));

            this.grdRelated.RootTable.Columns["CompanesCode"].DefaultValue = CoId;
            this.grdRelated.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdRelated.RootTable.Columns["CompanesCode"], Janus.Windows.GridEX.ConditionOperator.Equal, CoId));

            //this.grdStatus.RootTable.Columns["CompanesCode"].DefaultValue = CoId;
            //this.grdStatus.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdStatus.RootTable.Columns["CompanesCode"], Janus.Windows.GridEX.ConditionOperator.Equal, CoId));
            

            if (Current_Company != null)
            {
                this.grpcompanies.Text = "شرکت" + " " + this.grdCompanies.CurrentRow.Cells["CompanyName"].Value.ToString();
            }

            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("CompaniesCode", CoId));
            this.showMarketingActivityList1.Fill(Parameter);
            this.grdShow.Refetch();

            List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("CompaniesCode", this.CoId));
            this.letter_Scan1.Document  =(Byte[]) RASF.General.Lists.Base.BaseList<Object>.FillScalar("Companies_Letter_Select", Parameter2);
            
            
        }

        private void grdStatus_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }

        private void SummaryofCompaniesstatus_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.letter_Scan1.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.grdCompanies.SelectedItems.Count > 0)
            {
                CoId = ((RASF.General.Data.Companies_Base)grdCompanies.CurrentRow.DataRow).CompaniesCode;

            }
            if (this.letter_Scan1.Document != null)
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("CompaniesCode", this.CoId));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("Letter", this.letter_Scan1.Document));
                RASF.General.Lists.Base.BaseList<Object>.FillScalar("Companies_Letter_Update", Parameter);
            }
        }

        private void grdCompanies_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

            if (Convert.ToBoolean(e.Row.Cells["ImportantCompany"].Value) == true)
            {
                e.Row.Cells["CompanyName"].FormatStyle = this.ImportantFormat;
            }
        }
    }
}
