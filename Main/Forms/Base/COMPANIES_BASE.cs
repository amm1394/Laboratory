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
    public partial class COMPANIES_BASE : RASF.General.Forms.Base.DockContentForm
    {
        public COMPANIES_BASE(Janus.Windows.GridEX.InheritableBoolean IsEditAble)
        {
            InitializeComponent();
            SetGrids(IsEditAble);
            this.btnTafahom.Enabled = false;
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

            this.grdCompany.AllowEdit = IsEditAble;
            this.grdCompanyBase.AllowEdit = IsEditAble;
            this.grdEmail.AllowEdit = IsEditAble;
            this.grdEnglish.AllowEdit = IsEditAble;
            this.grdFax.AllowEdit = IsEditAble;
            this.grdMobile.AllowEdit = IsEditAble;
            this.grdPhone.AllowEdit = IsEditAble;

            this.grdCompany.AllowDelete = IsEditAble;
            this.grdCompanyBase.AllowDelete = IsEditAble;
            this.grdEmail.AllowDelete = IsEditAble;
            this.grdEnglish.AllowDelete = IsEditAble;
            this.grdFax.AllowDelete = IsEditAble;
            this.grdMobile.AllowDelete = IsEditAble;
            this.grdPhone.AllowDelete = IsEditAble;

            if (IsEditAble == Janus.Windows.GridEX.InheritableBoolean.False)
            {
                this.ShowpnlSave = false;
            }
        }
        Guid CoId;
        private void COMPANIES_BASE_Load(object sender, EventArgs e)
        {
            txtArgu.Enabled = false;
            txtEconomyCode.Enabled = false;
            txtNationalCode.Enabled = false;
            txtSabt.Enabled = false;
            datepictafahomSign.SelectedDateTime = DateTime.Now;
            datepicTafahomFrom.SelectedDateTime = DateTime.Now;
            datepicTafahomTo.SelectedDateTime = DateTime.Now;

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
            this.companiesEmailList1.Fill();
            this.companies_EmailForInvoiceList1.Fill();
            this.companiesPhoneNumList1.Fill();
            this.companiesFaxNumList1.Fill();
            this.companiesEnglishList1.Fill();
            this.companiesSendTypeList1.Fill();
            this.companies_MobileNumList1.Fill();
           // this.haghighiHoghughiList1.Fill();
            this.connectorOfCompaniesList1.Fill();
            this.sabtCompanyUserList1.Fill();
            this.tafahomNameList1.Fill();
            this.cooperationGroup_TafahomNameList1.Fill();

            //List<System.Data.SqlClient.SqlParameter> UsersGroup = new List<System.Data.SqlClient.SqlParameter>();
            //UsersGroup.Add(new System.Data.SqlClient.SqlParameter("@groupName", "Receptionists"));
            //this.usersGroupList1.Fill(UsersGroup);

            General.Classes.Utility.CreateDropDow(drpCooperation, "Description", "Code", cooperationGroup_TafahomNameList1);
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
            this.grdEmail.Refetch();
            this.grdEnglish.Refetch();
            this.grdFax.Refetch();
            this.grdPhone.Refetch();
            this.grdMobile.Refetch();
            this.grdEmailInvoice.Refetch();
            this.grdTafahom.Refetch();

            this.grdCompanyBase.RemoveBindingContextChanged();
            this.grdCompany.RemoveBindingContextChanged();
            this.grdEmail.RemoveBindingContextChanged();
            this.grdEnglish.RemoveBindingContextChanged();
            this.grdFax.RemoveBindingContextChanged();
            this.grdPhone.RemoveBindingContextChanged();
            this.grdMobile.RemoveBindingContextChanged();
            this.grdEmailInvoice.RemoveBindingContextChanged();
            this.grdTafahom.RemoveBindingContextChanged();

           

            this.grdCompanyBase.SelectionChanged += new System.EventHandler(this.grdCompanyBase_SelectionChanged);
            this.grdCompanyBase_SelectionChanged(sender,e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rdhaghighi.Checked == true || rdhoghughi.Checked == true)
            {

                if (this.grdCompanyBase.SelectedItems.Count > 0)
                {
                    RASF.General.Data.Companies_Base Current_Company = (RASF.General.Data.Companies_Base)this.grdCompanyBase.SelectedItems[0].GetRow().DataRow;

                    if (Current_Company != null)
                    {
                        if (Current_Company.PostCode.Length == 10)
                        {
                            if (rdhoghughi.Checked == true && (string.IsNullOrWhiteSpace(txtEconomyCode.Text) == false || string.IsNullOrWhiteSpace(txtSabt.Text) == false || string.IsNullOrWhiteSpace(txtArgu.Text) == false))
                            {
                                Current_Company.HaghighiOrHoghughiCode = 1;
                                Current_Company.EconomicCode = txtArgu.Text;
                                Current_Company.SetNum = txtSabt.Text;
                                Current_Company.NationalArgument = txtArgu.Text;
                                Current_Company.NationalCode = "0";
                            }
                            else if (rdhaghighi.Checked == true && string.IsNullOrWhiteSpace(txtNationalCode.Text) == false)
                            {
                                Current_Company.HaghighiOrHoghughiCode = 0;
                                Current_Company.NationalCode = txtNationalCode.Text;
                                Current_Company.EconomicCode = "0";
                                Current_Company.SetNum = "0";
                                Current_Company.NationalArgument = "0";
                            }

                            Current_Company.UserIDUpdate = RASF.General.Classes.Global.CurrentUserCode;
                            Current_Company.UserId = RASF.General.Classes.Global.CurrentUserCode;
                            Current_Company.foreigners = CHKForin.Checked;
                            if (Current_Company.Marketing == true)
                                Current_Company.Marketing = Convert.ToBoolean(0);
                            this.companiesBaseList1.Update();
                        }
                        else
                        {
                            MessageBox.Show("کد پستی اشتباه است");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("حقیقی یا حقوقی !!!");
                }
            }
   
            this.companiesEmailList1.Update();
            this.companiesEnglishList1.Update();
            this.companiesFaxNumList1.Update();
            this.companiesPhoneNumList1.Update();
            this.companies_MobileNumList1.Update();
            this.companies_EmailForInvoiceList1.Update();

            this.txttafahomno.Text = "";
            this.datepictafahomSign.SelectedDateTime = DateTime.Now;
            this.datepicTafahomFrom.SelectedDateTime = DateTime.Now;
            this.datepicTafahomTo.SelectedDateTime = DateTime.Now;
            this.chkIntroduction.Checked = false;
                       
        }

        private void grdCompanyBase_SelectionChanged(object sender, EventArgs e)
        {
            RASF.General.Data.Companies_Base Current_Company = (RASF.General.Data.Companies_Base)this.grdCompanyBase.SelectedItems[0].GetRow().DataRow;

          
            if (Current_Company != null && Current_Company.HaghighiOrHoghughiCode == 1)
            {
                rdhoghughi.Checked = true;
                txtArgu.Text = Current_Company.NationalArgument;
                txtEconomyCode.Text = Current_Company.EconomicCode;
                txtSabt.Text = Current_Company.SetNum;
            }
            else if (Current_Company != null && Current_Company.HaghighiOrHoghughiCode == 0)
            {
                rdhaghighi.Checked = true;
                txtNationalCode.Text = Current_Company.NationalCode; 
            }

            if (this.grdCompanyBase.SelectedItems[0].Position > -1)
            {
                CoId = ((RASF.General.Data.Companies_Base)grdCompany.CurrentRow.DataRow).CompaniesCode;
                CHKForin.Checked = Current_Company.foreigners;
            }
            else
            {
                CoId = new Guid();
                //txtArgu.Text = "";
                //txtEconomyCode.Text = "";
                //txtSabt.Text = "";
                //txtNationalCode.Text = "";
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

            this.grdEmailInvoice.RootTable.Columns["CompanyCode"].DefaultValue = CoId;
            this.grdEmailInvoice.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdEmailInvoice.RootTable.Columns["CompanyCode"], Janus.Windows.GridEX.ConditionOperator.Equal, CoId));

            this.grdTafahom.RootTable.Columns["CompaniesCode"].DefaultValue = CoId;
            this.grdTafahom.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdTafahom.RootTable.Columns["CompaniesCode"], Janus.Windows.GridEX.ConditionOperator.Equal, CoId));
 
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

            txttafahomno.Text = "";
            txtDiscount.Text = "";
            txtCheque.Text = "";
            txtTasviyeh.Text = "";
            chkIntroduction.Checked = false;
            txtConnector.Text = "";
            txttechnical.Text = "";
            txtSignatory.Text = "";
            drpCooperation.SelectedIndex = -1;
            datepictafahomSign.SelectedDateTime = DateTime.Now;
            datepicTafahomFrom.SelectedDateTime = DateTime.Now;
            datepicTafahomTo.SelectedDateTime = DateTime.Now;


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
            if(rdhoghughi.Checked ==true)
            {
                txtSabt.Enabled = true;
                txtEconomyCode.Enabled = true;
                txtArgu.Enabled = true;
                txtNationalCode.Text = "";
            }
            else
            {
                txtSabt.Enabled = false;
                txtEconomyCode.Enabled = false;
                txtArgu.Enabled = false;
                txtSabt.Text= "";
                txtEconomyCode.Text = "";
                txtArgu.Text = "";
            }
        }

        private void rdhaghighi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdhaghighi.Checked == true)
            {
                txtNationalCode.Enabled = true;
                txtSabt.Text = "";
                txtEconomyCode.Text = "";
                txtArgu.Text = "";
            }
            else
            {
                txtNationalCode.Enabled = false;
                txtNationalCode.Text = "";
            }
        }

        private void txtEconomyCode_Leave(object sender, EventArgs e)
        {
            if (txtEconomyCode.Text.Length != 11)
            {
                MessageBox.Show("کد اقتصادی صحیح نمی باشد");
                txtEconomyCode.Text = "";
          //      txtEconomyCode.Focus();
            }
        }

        private void txtArgu_Leave(object sender, EventArgs e)
        {
            if (txtArgu.Text.Length != 11)
            {
                MessageBox.Show("شناسه ملی صحیح نمی باشد");
                txtArgu.Text = "";
             //   txtArgu.Focus();
            }
        }

        private void txtNationalCode_Leave(object sender, EventArgs e)
        {
            if (txtNationalCode.Text.Length != 10)
            {
                MessageBox.Show("کد ملی صحیح نمی باشد");
                txtNationalCode.Text = "";
             //   txtNationalCode.Focus();
            }
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

     
        private void btnTafahom_Click(object sender, EventArgs e)
        {
             
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("CompaniesCode",(this.grdCompanyBase.CurrentRow.Cells["CompaniesCode"].Value)));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("TafahomnameNo", txttafahomno.Text));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("TafahomNameSignDate",datepictafahomSign.SelectedDateTime ));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("TafahomNameDateFrom",datepicTafahomFrom.SelectedDateTime));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("TafahomNameDateTo",datepicTafahomTo.SelectedDateTime ));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("HasIntroduction", chkIntroduction.Checked));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("Discount", txtDiscount.Text));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("UserName", RASF.General.Classes.Global.CurrentUserName));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("Cheque", txtCheque.Text));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("Tasviyeh", txtTasviyeh.Text));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("CoOperatopnGroupCode",1));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("Connector", txtConnector.Text));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("TechnicalAssis", txttechnical.Text));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("Signatory", txtSignatory.Text));
            RASF.General.Lists.BanksList.FillScalar("TafahomName_Insert", Parameter);

            this.tafahomNameList1.Fill();
            this.grdTafahom.RootTable.Columns["CompaniesCode"].DefaultValue = CoId;
            this.grdTafahom.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdTafahom.RootTable.Columns["CompaniesCode"], Janus.Windows.GridEX.ConditionOperator.Equal, CoId));

            this.grdTafahom.Refetch();

            txttafahomno.Text = "";
            txtDiscount.Text = "";
            txtCheque.Text = "";
            txtTasviyeh.Text = "";                 
            chkIntroduction.Checked = false;
            drpCooperation.SelectedIndex = -1;
            txtConnector.Text = "";
            txttechnical.Text = "";
            txtSignatory.Text = "";
            datepictafahomSign.SelectedDateTime = DateTime.Now;
            datepicTafahomFrom.SelectedDateTime = DateTime.Now;
            datepicTafahomTo.SelectedDateTime = DateTime.Now;
        }

        private void grdTafahom_SelectionChanged(object sender, EventArgs e)
        {
          
        }

        private void grdTafahom_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            Int64 TafahomCode = (Int64)(this.grdTafahom.CurrentRow.Cells["TafahomNameCode"].Value);
            RASF.Main.Forms.Base.EditTafahomName EditTafahomName = new RASF.Main.Forms.Base.EditTafahomName(TafahomCode);
            EditTafahomName.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
            this.companiesEmailList1.Fill();
            this.companies_EmailForInvoiceList1.Fill();
            this.companiesPhoneNumList1.Fill();
            this.companiesFaxNumList1.Fill();
            this.companiesEnglishList1.Fill();
            this.companiesSendTypeList1.Fill();
            this.companies_MobileNumList1.Fill();
            // this.haghighiHoghughiList1.Fill();
            this.connectorOfCompaniesList1.Fill();
            this.sabtCompanyUserList1.Fill();
            this.tafahomNameList1.Fill();
            this.cooperationGroup_TafahomNameList1.Fill();

            this.grdCompanyBase.Refetch();
            this.grdCompany.Refetch();
            this.grdEmail.Refetch();
            this.grdEnglish.Refetch();
            this.grdFax.Refetch();
            this.grdPhone.Refetch();
            this.grdMobile.Refetch();
            this.grdEmailInvoice.Refetch();
            this.grdTafahom.Refetch();
        }

      
    }
}
