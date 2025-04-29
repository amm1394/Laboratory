using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms
{
    [System.ComponentModel.Category("RASF")]
    public partial class COMPANIES_BASEForMarketing : RASF.General.Forms.Base.DockContentForm
    {
        public COMPANIES_BASEForMarketing(Janus.Windows.GridEX.InheritableBoolean IsEditAble)
        {
            InitializeComponent();
            SetGrids(IsEditAble);
        }

        private void SetGrids(Janus.Windows.GridEX.InheritableBoolean IsEditAble)
        {
            this.grdCompany.AllowAddNew = IsEditAble;
            this.grdCompanyBase.AllowAddNew = IsEditAble;
            this.grdEmail.AllowAddNew = IsEditAble;
            this.grdEnglish.AllowAddNew = IsEditAble;
            this.grdFax.AllowAddNew = IsEditAble;
            this.grdMobile.AllowAddNew = IsEditAble;
            this.grdPhone.AllowAddNew = IsEditAble;
            this.grdRelated.AllowAddNew = IsEditAble;

            this.grdCompany.AllowEdit = IsEditAble;
            this.grdCompanyBase.AllowEdit = IsEditAble;
            this.grdEmail.AllowEdit = IsEditAble;
            this.grdEnglish.AllowEdit = IsEditAble;
            this.grdFax.AllowEdit = IsEditAble;
            this.grdMobile.AllowEdit = IsEditAble;
            this.grdPhone.AllowEdit = IsEditAble;
            this.grdRelated.AllowEdit = IsEditAble;

            this.grdCompany.AllowDelete = IsEditAble;
            this.grdCompanyBase.AllowDelete = IsEditAble;
            this.grdEmail.AllowDelete = IsEditAble;
            this.grdEnglish.AllowDelete = IsEditAble;
            this.grdFax.AllowDelete = IsEditAble;
            this.grdMobile.AllowDelete = IsEditAble;
            this.grdPhone.AllowDelete = IsEditAble;
            this.grdRelated.AllowDelete = IsEditAble;

            if (IsEditAble == Janus.Windows.GridEX.InheritableBoolean.False)
            {
                this.ShowpnlSave = false;
            }
        }

        Guid CoId;
        private void COMPANIES_BASE_Load(object sender, EventArgs e)
        {
          

            this.companies_BaseMarketingList1.Fill();
            this.companiesAcqaintanceList1.Fill();
            this.companiesActivityTypeList1.Fill();
            this.companiesAgencyListList1.Fill();
            this.companiesCooperationTypeList1.Fill();
            this.companiesProvincisList1.Fill();
         //   this.companiesSecurityTypeList1.Fill();
            this.activeNonActiveList1.Fill();
            this.userList1.Fill();
            this.companiesEmailList1.Fill();
            this.companiesPhoneNumList1.Fill();
            this.companiesFaxNumList1.Fill();
            this.companiesEnglishList1.Fill();
            this.companiesSendTypeList1.Fill();
            this.companies_MobileNumList1.Fill();
            this.connectorOfCompaniesList1.Fill();
            this.sabtCompanyUserList1.Fill();
            this.companies_PeopleRelatedList1.Fill();

            //List<System.Data.SqlClient.SqlParameter> UsersGroup = new List<System.Data.SqlClient.SqlParameter>();
            //UsersGroup.Add(new System.Data.SqlClient.SqlParameter("@groupName", "Receptionists"));
            //this.usersGroupList1.Fill(UsersGroup);

            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["AcquaintaceCode"], this.companiesAcqaintanceList1, "AcquaintanceCode", "AcquaintanceName");
            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["ActivityCode"], this.companiesActivityTypeList1, "ActivityCode", "ActivityName");
            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["UserId"], this.sabtCompanyUserList1, "UserId", "UserName");
            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["ProvinceCode"], this.companiesProvincisList1, "PronvincesCode", "ProvinceName");
            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["StateActivity"], this.activeNonActiveList1, "Code", "ActOrNonAct");
            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["CooperationCode"], this.companiesCooperationTypeList1, "CooperationCode", "CooperationName");
            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["AgencyCode"], this.companiesAgencyListList1, "AgencyCode", "AgencyName");
            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["ConnectorId"], this.connectorOfCompaniesList1, "UserId", "UserName");
        

          
           this.grdCompanyBase.RootTable.Columns["AcquaintaceCode"].DefaultValue = this.companiesAcqaintanceList1[0].AcquaintanceCode;
           this.grdCompanyBase.RootTable.Columns["ActivityCode"].DefaultValue =new Guid( "e19afebf-60df-479d-b75e-5ab114458031");//this.companiesActivityTypeList1[14].ActivityCode;
           this.grdCompanyBase.RootTable.Columns["UserId"].DefaultValue = this.sabtCompanyUserList1[5].UserId;
           this.grdCompanyBase.RootTable.Columns["ProvinceCode"].DefaultValue =new Guid("23B34485-485D-4E48-B4EF-ABE8B2876F55");//this.companiesProvincisList1[7].PronvincesCode;
           this.grdCompanyBase.RootTable.Columns["StateActivity"].DefaultValue = this.activeNonActiveList1[0].Code;
           this.grdCompanyBase.RootTable.Columns["CooperationCode"].DefaultValue = this.companiesCooperationTypeList1[0].CooperationCode;
           this.grdCompanyBase.RootTable.Columns["AgencyCode"].DefaultValue =new Guid( "7A2EEE8F-AEBF-49F6-818E-BB2E2EDB5154");//this.companiesAgencyListList1[4].AgencyCode;
           this.grdCompanyBase.RootTable.Columns["ConnectorId"].DefaultValue = this.connectorOfCompaniesList1[1].UserId;
                 
            this.grdCompanyBase.Refetch();
            this.grdCompany.Refetch();
            this.grdEmail.Refetch();
            this.grdEnglish.Refetch();
            this.grdFax.Refetch();
            this.grdPhone.Refetch();
            this.grdMobile.Refetch();
            this.grdRelated.Refetch();

            this.grdCompanyBase.RemoveBindingContextChanged();
            this.grdCompany.RemoveBindingContextChanged();
            this.grdEmail.RemoveBindingContextChanged();
            this.grdEnglish.RemoveBindingContextChanged();
            this.grdFax.RemoveBindingContextChanged();
            this.grdPhone.RemoveBindingContextChanged();
            this.grdMobile.RemoveBindingContextChanged();
            this.grdRelated.RemoveBindingContextChanged();

           

            this.grdCompanyBase.SelectionChanged += new System.EventHandler(this.grdCompanyBase_SelectionChanged);
            this.grdCompanyBase_SelectionChanged(sender,e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            this.companies_BaseMarketingList1.Update();
            this.companiesEmailList1.Update();
            this.companiesEnglishList1.Update();
            this.companiesFaxNumList1.Update();
            this.companiesPhoneNumList1.Update();
            this.companies_MobileNumList1.Update();
            this.companies_PeopleRelatedList1.Update();
                       
        }

        private void grdCompanyBase_SelectionChanged(object sender, EventArgs e)
        {
            RASF.General.Data.Companies_Base Current_Company = (RASF.General.Data.Companies_Base)this.grdCompanyBase.SelectedItems[0].GetRow().DataRow;

            if (this.grdCompanyBase.SelectedItems[0].Position > -1)
            {
                CoId = ((RASF.General.Data.Companies_Base)grdCompany.CurrentRow.DataRow).CompaniesCode;
              
            }
            else
            {
                CoId = new Guid();
            
            }

            this.grdPhone.RootTable.Columns["CompanyCode"].DefaultValue = CoId;
            this.grdPhone.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdPhone.RootTable.Columns["CompanyCode"], Janus.Windows.GridEX.ConditionOperator.Equal, CoId));

            this.grdFax.RootTable.Columns["CompanyCode"].DefaultValue = CoId;
            this.grdFax.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdFax.RootTable.Columns["CompanyCode"], Janus.Windows.GridEX.ConditionOperator.Equal, CoId));

            this.grdEmail.RootTable.Columns["CompanyCode"].DefaultValue = CoId;
            this.grdEmail.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdEmail.RootTable.Columns["CompanyCode"], Janus.Windows.GridEX.ConditionOperator.Equal, CoId));

            this.grdEnglish.RootTable.Columns["EnglishCode"].DefaultValue = CoId;
            this.grdEnglish.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdEnglish.RootTable.Columns["EnglishCode"], Janus.Windows.GridEX.ConditionOperator.Equal, CoId));

            this.grdMobile.RootTable.Columns["CompanyCode"].DefaultValue = CoId;
            this.grdMobile.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdMobile.RootTable.Columns["CompanyCode"], Janus.Windows.GridEX.ConditionOperator.Equal, CoId));

            this.grdRelated.RootTable.Columns["CompanesCode"].DefaultValue = CoId;
            this.grdRelated.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdRelated.RootTable.Columns["CompanesCode"], Janus.Windows.GridEX.ConditionOperator.Equal, CoId));

            
            if (this.grdEnglish.RowCount == 1)
            {
                this.grdEnglish.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            }
            else
            {
                this.grdEnglish.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            }

           // RASF.General.Data.Companies_Base Current_Company = (RASF.General.Data.Companies_Base)this.grdCompanyBase.SelectedItems[0].GetRow().DataRow;
            if (Current_Company != null)
            {
                this.grpCompanies.Text = "شرکت" + " " + this.grdCompanyBase.CurrentRow.Cells["CompanyName"].Value.ToString();
                this.groupBox1.Text = "اطلاعات تکمیلی شرکت" + " " + this.grdCompanyBase.CurrentRow.Cells["CompanyName"].Value.ToString();
            }
        }

        private void grdEnglish_RowCountChanged(object sender, EventArgs e)
        {
            if (this.grdEnglish.RowCount == 1)
            {
                this.grdEnglish.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            }
            else
            {
                this.grdEnglish.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            }
        }

        private void grdCompanyBase_RowCountChanged(object sender, EventArgs e)
        {
            this.grdCompany.Refetch();
        }


        private void rdhoghughi_CheckedChanged(object sender, EventArgs e)
        {
            //if(rdhoghughi.Checked ==true)
            //{
            //    txtSabt.Enabled = true;
            //    txtEconomyCode.Enabled = true;
            //    txtArgu.Enabled = true;
            //    txtNationalCode.Text = "";
            //}
            //else
            //{
            //    txtSabt.Enabled = false;
            //    txtEconomyCode.Enabled = false;
            //    txtArgu.Enabled = false;
            //    txtSabt.Text= "";
            //    txtEconomyCode.Text = "";
            //    txtArgu.Text = "";
            //}
        }

        private void rdhaghighi_CheckedChanged(object sender, EventArgs e)
        {
            //if (rdhaghighi.Checked == true)
            //{
            //    txtNationalCode.Enabled = true;
            //    txtSabt.Text = "";
            //    txtEconomyCode.Text = "";
            //    txtArgu.Text = "";
            //}
            //else
            //{
            //    txtNationalCode.Enabled = false;
            //    txtNationalCode.Text = "";
            //}
        }

        private void txtEconomyCode_Leave(object sender, EventArgs e)
        {
            //if (txtEconomyCode.Text.Length != 12)
            //{
            //    MessageBox.Show("کد اقتصادی صحیح نمی باشد");
            //    txtEconomyCode.Text = "";
            //    txtEconomyCode.Focus();
            //}
        }

        private void txtArgu_Leave(object sender, EventArgs e)
        {
            //if (txtArgu.Text.Length != 11)
            //{
            //    MessageBox.Show("شناسه ملی صحیح نمی باشد");
            //    txtArgu.Text = "";
            //    txtArgu.Focus();
            //}
        }

        private void txtNationalCode_Leave(object sender, EventArgs e)
        {
            //if (txtNationalCode.Text.Length != 10)
            //{
            //    MessageBox.Show("کد ملی صحیح نمی باشد");
            //    txtNationalCode.Text = "";
            //    txtNationalCode.Focus();
            //}
        }

        private void grdCompanyBase_AddingRecord(object sender, CancelEventArgs e)
        {
            string FindCompany;
            string row = this.grdCompanyBase.CurrentRow.Cells["CompanyName"].Value.ToString();
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("CompanyName", String.Format("%{0}%", row)));
            FindCompany = (string)RASF.General.Lists.BanksList.FillScalar("findCompaniesName_Select", Parameter);
            if (FindCompany == "true")
            {
                MessageBox.Show("نام شرکت تکراری می باشد.");
            }
        }

    }
}
