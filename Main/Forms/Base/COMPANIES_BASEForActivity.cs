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
    public partial class COMPANIES_BASEForActivity : RASF.General.Forms.Base.DockContentForm
    {
        public COMPANIES_BASEForActivity(Janus.Windows.GridEX.InheritableBoolean IsEditAble)
        {
            InitializeComponent();
            this.companiesBaseList1.spName = "Companies_BaseForActivity";
          
        }

        private void SetGrids(Janus.Windows.GridEX.InheritableBoolean IsEditAble)
        {
            this.grdCompany.AllowAddNew = IsEditAble;
            this.grdCompanyBase.AllowAddNew = IsEditAble;
        
            this.grdCompany.AllowEdit = IsEditAble;
            this.grdCompanyBase.AllowEdit = IsEditAble;
         

            this.grdCompany.AllowDelete = IsEditAble;
            this.grdCompanyBase.AllowDelete = IsEditAble;
          

            if (IsEditAble == Janus.Windows.GridEX.InheritableBoolean.False)
            {
                this.ShowpnlSave = false;
            }
        }
        Guid CoId;
        private void COMPANIES_BASE_Load(object sender, EventArgs e)
        {
         

            this.companiesBaseList1.Fill();
            this.companiesAcqaintanceList1.Fill();
            this.companiesActivityTypeList1.Fill();
            this.companiesAgencyListList1.Fill();
            this.companiesCooperationTypeList1.Fill();
            this.cooperationGroupList1.Fill();
            this.companiesProvincisList1.Fill();
            this.companiesSecurityTypeList1.Fill();
            this.activeNonActiveList1.Fill();
            this.userList1.Fill();
           
            this.companies_EmailForInvoiceList1.Fill();
           
            this.companiesFaxNumList1.Fill();
           
            this.companiesSendTypeList1.Fill();
          
            // this.haghighiHoghughiList1.Fill();
            this.connectorOfCompaniesList1.Fill();
            this.sabtCompanyUserList1.Fill();
          
            this.cooperationGroup_TafahomNameList1.Fill();

            //List<System.Data.SqlClient.SqlParameter> UsersGroup = new List<System.Data.SqlClient.SqlParameter>();
            //UsersGroup.Add(new System.Data.SqlClient.SqlParameter("@groupName", "Receptionists"));
            //this.usersGroupList1.Fill(UsersGroup);

        
            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["AcquaintaceCode"], this.companiesAcqaintanceList1, "AcquaintanceCode", "AcquaintanceName");
            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["ActivityCode"], this.companiesActivityTypeList1, "ActivityCode", "ActivityName");
            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["UserId"], this.sabtCompanyUserList1, "UserId", "UserName");
            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["ProvinceCode"], this.companiesProvincisList1, "PronvincesCode", "ProvinceName");
            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["StateEmail"], this.activeNonActiveList1, "Code", "ActOrNonAct");
            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["SecurityCode"], this.companiesSecurityTypeList1, "SecurityCode", "Name");
            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["StateActivity"], this.activeNonActiveList1, "Code", "ActOrNonAct");
            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["SendReport"], this.companiesSendTypeList1, "SendTypeCode", "SendTypeName");
            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["CooperationCode"], this.companiesCooperationTypeList1, "CooperationCode", "CooperationName");
            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["CooperationGroupCode"], this.cooperationGroupList1, "CooperationGroupCode", "CooperationName");
            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["AgencyCode"], this.companiesAgencyListList1, "AgencyCode", "AgencyName");
            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["CHKTax"], this.activeNonActiveList1, "Code", "ActOrNonAct");
          //  General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["HaghighiOrHoghughiCode"], this.haghighiHoghughiList1, "Code", "Name");
            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["ConnectorId"], this.connectorOfCompaniesList1, "UserId", "UserName");
        

          
           this.grdCompanyBase.RootTable.Columns["AcquaintaceCode"].DefaultValue = this.companiesAcqaintanceList1[0].AcquaintanceCode;
           this.grdCompanyBase.RootTable.Columns["ActivityCode"].DefaultValue = this.companiesActivityTypeList1[0].ActivityCode;
           this.grdCompanyBase.RootTable.Columns["UserId"].DefaultValue = this.sabtCompanyUserList1[0].UserId;
           this.grdCompanyBase.RootTable.Columns["ProvinceCode"].DefaultValue = this.companiesProvincisList1[0].PronvincesCode;
           this.grdCompanyBase.RootTable.Columns["StateEmail"].DefaultValue = this.activeNonActiveList1[0].Code;
           this.grdCompanyBase.RootTable.Columns["SecurityCode"].DefaultValue = this.companiesSecurityTypeList1[0].SecurityCode;
           this.grdCompanyBase.RootTable.Columns["StateActivity"].DefaultValue = this.activeNonActiveList1[0].Code;
           this.grdCompanyBase.RootTable.Columns["SendReport"].DefaultValue = this.companiesSendTypeList1[0].SendTypeCode;
           this.grdCompanyBase.RootTable.Columns["CooperationCode"].DefaultValue = this.companiesCooperationTypeList1[0].CooperationCode;
           this.grdCompanyBase.RootTable.Columns["CooperationGroupCode"].DefaultValue = this.cooperationGroupList1[1].CooperationGroupCode;
           this.grdCompanyBase.RootTable.Columns["AgencyCode"].DefaultValue = this.companiesAgencyListList1[11].AgencyCode;
           this.grdCompanyBase.RootTable.Columns["CHKTax"].DefaultValue = this.activeNonActiveList1[0].Code;
          // this.grdCompanyBase.RootTable.Columns["HaghighiOrHoghughiCode"].DefaultValue = this.haghighiHoghughiList1[1].Code;
           this.grdCompanyBase.RootTable.Columns["ConnectorId"].DefaultValue = this.connectorOfCompaniesList1[1].UserId;
                 
            this.grdCompanyBase.Refetch();
            this.grdCompany.Refetch();
         

            this.grdCompanyBase.RemoveBindingContextChanged();
            this.grdCompany.RemoveBindingContextChanged();
                    

         
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.companiesBaseList1.Update();
         
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

          
            if (Current_Company != null)
            {
                this.grpCompanies.Text = "شرکت" + " " + this.grdCompanyBase.CurrentRow.Cells["CompanyName"].Value.ToString();
                this.groupBox1.Text = "اطلاعات تکمیلی شرکت" + " " + this.grdCompanyBase.CurrentRow.Cells["CompanyName"].Value.ToString();
            }
        
        }

     

        private void grdCompanyBase_RowCountChanged(object sender, EventArgs e)
        {
            this.grdCompany.Refetch();
        }

        private void grdCompanyBase_AddingRecord(object sender, CancelEventArgs e)
        {
            string FindCompany;
            string row = this.grdCompanyBase.CurrentRow.Cells["CompanyName"].Value.ToString();
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("CompanyName", String.Format("%{0}%", row)));
            FindCompany = (string)RASF.General.Lists.BanksList.FillScalar("findCompaniesName_Select", Parameter);
            if (FindCompany =="true")
            {
                MessageBox.Show("نام شرکت تکراری می باشد. به آیتم شرکت (بازاریابی مراجعه کنید )");
            }
        }

     
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.companiesBaseList1.Fill();
 

            this.grdCompanyBase.Refetch();
            this.grdCompany.Refetch();
       
        }

      
    }
}
