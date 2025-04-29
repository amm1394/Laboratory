using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Stimulsoft.Report.Dictionary;
//using System.

namespace RASF.Main.Forms.Reception
{
    public partial class New_ReceptionForAgency : RASF.General.Forms.Base.DockContentForm
    {
        protected delegate void AddTestDelegete(RASF.General.Events.ReturnTestEventArgs e);
        protected RASF.General.Data.Parts_Master Parts_Master;
        private RASF.General.Lists.MasterTestStatusList CopyTest;
        private Byte[] Pic_Array;
        private Byte[] Pic_Array2;
        private RASF.Main.Controls.Reception.New_Recipt_Control Recipt_Control;
        private Main.Forms.Reception.AddTest AddTest_Form = new Main.Forms.Reception.AddTest();
        private Guid Executers;
        protected Guid CompaniesReportCode;
        private DateTime DateMarketing;
        private DateTime DateMarketingR;
        private string UserEmail;
        private string ConnectorEmail;
        private string Company;
        private string UserEmailR;
        private string CompanyR;
        private Int32 ContractNo;
        public New_ReceptionForAgency()
        {
            InitializeComponent();
            this.banksList1.spName = "CheckInfoOfCompany";
        }

        private void Reception_Load(object sender, EventArgs e)
        {
            if (DesignMode == false)
            {
                this.grdPartsMaster.RemoveBindingContextChanged();
                this.labList1.Fill();
                this.mainTestList1.Fill();
                this.companiesBaseList1.Fill();
                this.companiesActivityTypeList1.Fill();
                this.yes_NoList1.Fill();
                this.yes_NoForDestructList1.Fill();
                this.sampleSendingTypeList1.Fill();
              //  this.reportSendingTypeList1.Fill();
                this.companiesAgencyListList1.Fill();

                this.chkPersian.Checked = true; //گزارش فارسی
                this.chkEmail.Checked = false;
                this.chkFax.Checked = false;
                this.chkPost.Checked = false;

                List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                Parameters.Add(new System.Data.SqlClient.SqlParameter("FINANCAILYEAR", RASF.General.Classes.Global.FinancialYear));
                this.new_ReceiptList1.Fill(Parameters);
                
                this.Recipt_Control = new Controls.Reception.New_Recipt_Control();
                this.Recipt_Control.Dock = DockStyle.Fill;
                this.Recipt_Control.DataSource = new RASF.General.Lists.New_ReceiptList();
                this.chkPersian.Checked = true;

                List<System.Data.SqlClient.SqlParameter> UsersGroup = new List<System.Data.SqlClient.SqlParameter>();
                UsersGroup.Add(new System.Data.SqlClient.SqlParameter("@groupName", "Receptionists"));
                this.usersGroupList1.Fill(UsersGroup);
                //this.usersGroupList1[0].UserId = RASF.General.Classes.Global.CurrentUserCode;

                List<System.Data.SqlClient.SqlParameter> ExecuterGroup = new List<System.Data.SqlClient.SqlParameter>();
                ExecuterGroup.Add(new System.Data.SqlClient.SqlParameter("@groupName", "Executers"));
                this.usersGroupList2.Fill(ExecuterGroup);

                this.companiesBaseList2.AddRange(this.companiesBaseList1.list);

                this.grdCompaniesReport.Refetch();
                this.grdCompanisInvoice.Refetch();
                this.grdPartsMaster.Refetch();

                General.Classes.Utility.CreateDropDow(dropDownUserID, "UserName", "UserId", usersGroupList1);
                dropDownUserID.SelectedValue = RASF.General.Classes.Global.CurrentUserCode;
                General.Classes.Utility.CreateDropDow(drpExecuters, "UserName", "UserId", usersGroupList2);
                General.Classes.Utility.CreateDropDow(drpOffices, "AgencyName", "AgencyCode", companiesAgencyListList1);
                General.Classes.Utility.CreateDropDow(dropDownSampleSendingTypeCode, "Name", "Code", sampleSendingTypeList1);
                //General.Classes.Utility.CreateDropDow(dropDownReportSendingTypeCode, "Name", "Code", reportSendingTypeList1);
                General.Classes.Utility.CreateDropDow(dropDownimmediate, "YesNo", "Code", yes_NoList1);
                General.Classes.Utility.CreateDropDow(dropDownTestForThePresence, "YesNo", "Code", yes_NoList1);
                General.Classes.Utility.CreateDropDow(drpOnSiteTesting, "YesNo", "Code", yes_NoList1);

                General.Classes.Utility.Create_DropDown(this.grdPartsMaster.RootTable.Columns["Destruct"], this.yes_NoForDestructList1, "Code", "YesNo");
                General.Classes.Utility.Create_DropDown(this.grdPartsMaster.RootTable.Columns["FeBase"], this.yes_NoList1, "Code", "YesNo");
                General.Classes.Utility.Create_DropDown(this.grdPartsMaster.RootTable.Columns["Void"], this.yes_NoList1, "Code", "YesNo");
                General.Classes.Utility.Create_DropDown(this.grdPartsMaster.RootTable.Columns["IsLarge"], this.yes_NoList1, "Code", "YesNo");
                General.Classes.Utility.Create_DropDown(this.grdPartsMaster.RootTable.Columns["TestLocation"], this.yes_NoList1, "Code", "YesNo");
                General.Classes.Utility.Create_DropDown(this.grdPartsMaster.RootTable.Columns["Marking"], this.yes_NoList1, "Code", "YesNo");

                this.grdPartsMaster.RootTable.Columns["Destruct"].DefaultValue = this.yes_NoList1[1].Code;
                this.grdPartsMaster.RootTable.Columns["FeBase"].DefaultValue = this.yes_NoList1[1].Code;
                this.grdPartsMaster.RootTable.Columns["IsLarge"].DefaultValue = this.yes_NoList1[0].Code;
                this.grdPartsMaster.RootTable.Columns["TestLocation"].DefaultValue = this.yes_NoList1[0].Code;
                this.grdPartsMaster.RootTable.Columns["Marking"].DefaultValue = this.yes_NoList1[0].Code;

               // this.dropDownUserID.SelectedIndex = 0;
                this.drpExecuters.SelectedIndex = -1;
                this.drpOffices.SelectedIndex = 0;
                this.dropDownTestForThePresence.SelectedIndex = 0;
                this.drpOnSiteTesting.SelectedIndex = 0;
             //   this.drpOnSiteTesting.SelectedIndex = 0;
                this.dropDownSampleSendingTypeCode.SelectedIndex = 1;
           //     this.dropDownReportSendingTypeCode.SelectedIndex = 4;
                this.dropDownimmediate.SelectedIndex = 0;
                this.drpOffices.SelectedValue = "7A2EEE8F-AEBF-49F6-818E-BB2E2EDB5154";

                DatePickerLetterDate.IsNull = true;
                DatePickerReceptionDate.IsNull = true;
                DatePickertxtDelivery.IsNull = true;

                DatePickerReceptionDate.SelectedDateTime = System.DateTime.Now.AddDays(0);
             //   DatePickerLetterDate.SelectedDateTime = System.DateTime.Now.AddDays(0);
                DatePickertxtDelivery.SelectedDateTime = System.DateTime.Now.AddDays(1);
              //  DatePickerTestForPresence.SelectedDateTime = System.DateTime.Now.AddDays(1);

                txtContractNo.Text = "جدید";

                TabPgGeneral.Enabled = false;
                TabPgSample.Enabled = false;

                CreateTab();

                this.letter_Scan1.Intial_Watcher();
                //?????
                if (this is RASF.Main.Forms.Reception.New_Reciption_EditForAgency)
                {
                    this.letter_Scan1.Document = this.contractsBaseList1.list[0].Letter;
                }
                else
                {
                    this.contractsBaseList1.Add(new General.Data.Contracts_Base());
                    this.contractsBaseList1.list[0].ContractsCode = this.contractsBaseList1.GetId();
                    this.contractsBaseList1.list[0].RowState = General.Enums.RowState.Added;
                    this.contractsBaseList1[0].ContractYear = RASF.General.Classes.Global.FinancialYear;
                }

                if (txtMobileNo.Text == "0" || txtMobileNo.Text == "*")
                {
                    txtMobileNo.Text = "";
                }
            }
        }

        private void CreateTab()
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("FINANCAILYEAR", RASF.General.Classes.Global.FinancialYear));
            this.masterteststatusList_Main1.Fill(Parameters);

            foreach (RASF.General.Data.Laboratory Lab in this.labList1)
            {
                Janus.Windows.UI.Tab.UITabPage TabPage = new Janus.Windows.UI.Tab.UITabPage(Lab.LaboratoryName);
                TabPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                TabPage.AutoScroll = true;
                foreach (RASF.General.Data.MainTest MainTest in this.mainTestList1.list.Where(Row => Row.LaboratoryCode_MainTest == Lab.LaboratoryCode))
                {
                    RASF.General.Lists.MasterTestStatusList masterteststatusList1 = new General.Lists.MasterTestStatusList();
                    masterteststatusList1.AddRange(this.masterteststatusList_Main1.list.Where(Row => Row.MainTestCode == MainTest.MainCode).ToList());

                    RASF.Main.Controls.Reception.Test_Control TestControl = new RASF.Main.Controls.Reception.Test_Control();
                    TestControl.TestName = MainTest.MainTestName;
                    TestControl.MainCode = MainTest.MainCode;
                    if (MainTest.CarriedoutintheBonyad == false)
                    {
                        TestControl.labBonyadRazi = "آزمون توسط پیمانکار فرعی انجام می شود";
                    }
                    TestControl.MASTERTESTSTATUSList = masterteststatusList1;
                    TestControl.Dock = DockStyle.Top;
                    TestControl.ReturnTest += TestControl_ReturnTest;
                    TabPage.Controls.Add(TestControl);
                    

                }
                this.tabLab.TabPages.Add(TabPage);
            }

            ///Create New Recition Control
            ///
            Janus.Windows.UI.Tab.UITabPage NewPage = new Janus.Windows.UI.Tab.UITabPage("پذیرش جدید");
            NewPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            NewPage.AutoScroll = true;
            this.Recipt_Control.AddClick += Recipt_Control_AddClick;
            NewPage.Controls.Add(this.Recipt_Control);
            this.tabLab.TabPages.Add(NewPage);
        }

        private void Recipt_Control_AddClick(object sender, EventArgs e)
        {
            if (AddTest_Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.Recipt_Control.RestTest();
                List<General.Data.New_Receipt> Test = AddTest_Form.GetTest();
                foreach (General.Data.New_Receipt test in Test)
                {
                    RASF.General.Data.MasterTestStatus NewRow = new General.Data.MasterTestStatus();
                    NewRow.InvoicePrice = test.InvoicePrice;
                    NewRow.IsCheck = test.IsChecked;
                    NewRow.LabInCome = test.LabInCome;
                    NewRow.MainTestCode = test.MainCode;
                    NewRow.MasterName = test.MasterName;
                    NewRow.MasterTestCode = test.MasterTestCode;
                    NewRow.NumberOfTests = test.Number;
                    NewRow.Tax = test.Tax;
                    NewRow.RowState = test.RowState;

                    this.AddTest(new RASF.General.Events.ReturnTestEventArgs(NewRow));
                }

                Parts_Master = (RASF.General.Data.Parts_Master)grdPartsMaster.CurrentRow.DataRow;

                if (Parts_Master != null)
                {
                    foreach (General.Data.MasterTestStatus test in Parts_Master.Tests)
                    {
                        if (Test.Count(r => r.MasterTestCode == test.MasterTestCode) == 0)
                        {
                            test.RowState = General.Enums.RowState.Deleted;
                        }
                    }

                    foreach (var item in Parts_Master.Tests.Where(r => r.RowState == General.Enums.RowState.Deleted).ToList())
                    {
                        Parts_Master.Tests.Remove(item);
                    }

                    foreach (Janus.Windows.UI.Tab.UITabPage Page in this.tabLab.TabPages)
                    {
                        foreach (UserControl TestControl in Page.Controls)
                        {
                            if (TestControl is RASF.Main.Controls.Reception.Test_Control)
                            {
                                ((RASF.Main.Controls.Reception.Test_Control)TestControl).Reset();
                                if (Parts_Master != null)
                                {
                                    List<General.Data.MasterTestStatus> list = Parts_Master.Tests.Where(Row => Row.MainTestCode == ((RASF.Main.Controls.Reception.Test_Control)TestControl).MainCode).ToList();
                                    if (list.Count > 0)
                                    {
                                        ((RASF.Main.Controls.Reception.Test_Control)TestControl).Set(list);
                                        this.AddTest_Form.SetTest(list);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void TestControl_ReturnTest(RASF.General.Events.ReturnTestEventArgs e)
        {
            if (this.InvokeRequired == true)
            {
                this.Invoke(new AddTestDelegete(this.AddTest), e);
            }
            else
            {
                this.AddTest(e);
            }
        }

        private void AddTest(RASF.General.Events.ReturnTestEventArgs e)
        {
            if (Parts_Master != null)
            {
                Parts_Master.SetTest(e.MasterTestStatus);
                this.lblPrice.Text = "قیمت کل " + this.partsMasterList1.TotalPrice().ToString() + " ریال";

                RASF.General.Data.New_Receipt row = this.new_ReceiptList1.Where(r => r.MasterTestCode == e.MasterTestStatus.MasterTestCode).SingleOrDefault();

                if (e.MasterTestStatus.IsCheck == true)
                {
                    row.RowState = e.MasterTestStatus.RowState;
                }
                else
                {
                    row.RowState = General.Enums.RowState.Deleted;
                }
                row.Number = e.MasterTestStatus.NumberOfTests;

                this.AddTest_Form.SetTest(e.MasterTestStatus);
                this.Recipt_Control.AddTest(row);
            }
        }

        private void grdCompanisInvoice_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.Companies_Base CurrentCompany = (RASF.General.Data.Companies_Base)this.grdCompanisInvoice.CurrentRow.DataRow;
            this.contractsBaseList1.list[0].Company_Invoice = CurrentCompany.CompaniesCode;
            this.groupBoxInvoice.Text = "نام شرکت جهت صدور صورت حساب  " + CurrentCompany.CompanyName;
            this.txtMobileNo.Text = CurrentCompany.MobileNum;
            DateMarketing = CurrentCompany.DateMarketing;
            UserEmail = CurrentCompany.Email;
            ConnectorEmail = CurrentCompany.EmailOfConnector;
            Company = CurrentCompany.CompanyName;
            if (this.contractsBaseList1.list[0].Company_Report == Guid.Empty)
            {
                this.contractsBaseList1.list[0].Company_Report = CurrentCompany.CompaniesCode;
                this.groupBoxReport.Text = "نام شرکت جهت صدور گزارش  " + CurrentCompany.CompanyName;
                CompaniesReportCode = CurrentCompany.CompaniesCode;
            }
            
            TabPgSample.Enabled = true;
            TabPgGeneral.Enabled = true;
            txtDescription.AppendText(this.grdCompanisInvoice.CurrentRow.Cells["Comment"].Value.ToString());

            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@CompaniesCode", CurrentCompany.CompaniesCode));
            this.banksList1.Fill(Parameter);
        }

        private void grdCompaniesReport_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.Companies_Base CurrentCompany = (RASF.General.Data.Companies_Base)this.grdCompaniesReport.CurrentRow.DataRow;
            this.contractsBaseList1.list[0].Company_Report = CurrentCompany.CompaniesCode;
            CompaniesReportCode = CurrentCompany.CompaniesCode;
            this.groupBoxReport.Text = "نام شرکت جهت صدور گزارش  " + CurrentCompany.CompanyName;
            DateMarketingR = CurrentCompany.DateMarketing;
            UserEmailR = CurrentCompany.Email;
            CompanyR = CurrentCompany.CompanyName;
            if (this.contractsBaseList1.list[0].Company_Invoice == Guid.Empty)
            {
                this.contractsBaseList1.list[0].Company_Invoice = CurrentCompany.CompaniesCode;
                this.groupBoxInvoice.Text = "نام شرکت جهت صدور صورت حساب  " + CurrentCompany.CompanyName;
                this.txtMobileNo.Text = CurrentCompany.MobileNum;
            }
            TabPgSample.Enabled = true;
            TabPgGeneral.Enabled = true;
        }

       private void grdPartsMaster_RowCountChanged(object sender, EventArgs e)
        {
            if (this.partsMasterList1.Count() > 0)
            {
                this.tabLab.Enabled = true;
            }
            else
            {
                this.tabLab.Enabled = false;
            }
        }

        protected void grdPartsMaster_SelectionChanged(object sender, EventArgs e)
        {
            Parts_Master = (RASF.General.Data.Parts_Master)grdPartsMaster.CurrentRow.DataRow;

            if (Parts_Master != null)
            {
                this.grpParts.Text = "شماره تنوع" + Parts_Master.PartNumber + "-" + " " + Parts_Master.Name;

                this.Recipt_Control.RestTest();
                this.AddTest_Form.Reset();
                foreach (Janus.Windows.UI.Tab.UITabPage Page in this.tabLab.TabPages)
                {
                    foreach (UserControl TestControl in Page.Controls)
                    {
                        if (TestControl is RASF.Main.Controls.Reception.Test_Control)
                        {
                            ((RASF.Main.Controls.Reception.Test_Control)TestControl).Reset();
                            if (Parts_Master != null)
                            {
                                List<General.Data.MasterTestStatus> list = Parts_Master.Tests.Where(Row => Row.MainTestCode == ((RASF.Main.Controls.Reception.Test_Control)TestControl).MainCode).ToList();
                                if (list.Count > 0)
                                {
                                    ((RASF.Main.Controls.Reception.Test_Control)TestControl).Set(list);
                                    this.AddTest_Form.SetTest(list);
                                    foreach (General.Data.MasterTestStatus Test in list)
                                    {
                                        RASF.General.Data.New_Receipt row = this.new_ReceiptList1.Where(r => r.MasterTestCode == Test.MasterTestCode).SingleOrDefault();
                                        row.Number = Test.NumberOfTests;
                                        row.RowState = Test.RowState;
                                        row.IsChecked = true;
                                        this.Recipt_Control.AddTest(row);
                                    }
                                }
                            }
                        }
                    }
                }
                this.tabLab.Enabled = true;
            }
            else
            {
                this.grpParts.Text = "";

                foreach (Janus.Windows.UI.Tab.UITabPage Page in this.tabLab.TabPages)
                {
                    foreach (UserControl TestControl in Page.Controls)
                    {
                        if (TestControl is RASF.Main.Controls.Reception.Test_Control)
                        {
                            ((RASF.Main.Controls.Reception.Test_Control)TestControl).Reset();
                        }
                    }
                }
                this.tabLab.Enabled = false;
            }
        }

        private void grdPartsMaster_RecordAdded(object sender, EventArgs e)
        {
            try
            {
                Parts_Master = (RASF.General.Data.Parts_Master)this.grdPartsMaster.SelectedItems[0].GetRow().DataRow;
                if (Parts_Master != null)
                {
                    this.grpParts.Text = "شماره تنوع" + Parts_Master.PartNumber + "-" + " " + Parts_Master.Name;
                    Parts_Master.Picture = this.Pic_Array;
                    Parts_Master.Picture2 = this.Pic_Array2;
                    Parts_Master.SmallPicture = RASF.General.Classes.Utility.ReadPic(this.Pic_Array, 48);
                    Parts_Master.SmallPicture2 = RASF.General.Classes.Utility.ReadPic(this.Pic_Array2, 48);
                    Parts_Master.ContractsBaseCode = this.contractsBaseList1.list[0].ContractsCode;
                    Parts_Master.PartNumber = this.partsMasterList1.GetPartNumber(this.contractsBaseList1.list[0].ContractsCode);
                    this.Pic_Array = null;
                    this.Pic_Array2 = null;
                   
                }
            }
            catch
            { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            this.contractsBaseList1[0].Delivery = DatePickertxtDelivery.SelectedDateTime;
            this.contractsBaseList1[0].ReceptionDate = DatePickerReceptionDate.SelectedDateTime;
            this.contractsBaseList1[0].immediate = Convert.ToByte(dropDownimmediate.SelectedValue);
            this.contractsBaseList1[0].TestForThePresence = Convert.ToByte(dropDownTestForThePresence.SelectedValue);
            this.contractsBaseList1[0].OnSiteTesting = Convert.ToByte(drpOnSiteTesting.SelectedValue);
            this.contractsBaseList1[0].UserID = (Guid)(dropDownUserID.SelectedValue);
            this.contractsBaseList1[0].SampleSendingTypeCode = (Guid)(dropDownSampleSendingTypeCode.SelectedValue);
          //  this.contractsBaseList1[0].ReportSendingTypeCode = (Guid)(dropDownReportSendingTypeCode.SelectedValue);
            this.contractsBaseList1[0].Referred = txtReferred.Text;
            this.contractsBaseList1[0].ExpertCompany = txtExpert.Text;
            this.contractsBaseList1[0].CellPhoneExpert = txtCellExpert.Text;
            this.contractsBaseList1[0].NationalCodeReferred = txtNationalCodeReferred.Text;
            //this.contractsBaseList1[0].LetterNo = txtLetterNo.Text;
            //this.contractsBaseList1[0].LetterDate = DatePickerLetterDate.SelectedDateTime;
            if (DatePickerLetterDate.SelectedDateTime > DateTime.MinValue)
            {
                this.contractsBaseList1[0].LetterDate = DatePickerLetterDate.SelectedDateTime;
                this.contractsBaseList1[0].LetterNo = txtLetterNo.Text;
            }
            else
            {
                txtLetterNo.Text = "";
                this.contractsBaseList1[0].LetterNo = txtLetterNo.Text;
                this.contractsBaseList1[0].LetterDate = System.DateTime.Now.AddDays(0);

            }
            this.contractsBaseList1[0].Description = txtDescription.Text;
            this.contractsBaseList1[0].EnglishReporter = chkEnglish.Checked;
            this.contractsBaseList1[0].PersianReport = this.chkPersian.Checked;
            this.contractsBaseList1[0].InsertPicRecieption = this.chkInsPic.Checked;
            this.contractsBaseList1[0].Uncertainty = chkGhateyat.Checked;
            this.contractsBaseList1[0].Executers = (Guid)drpExecuters.SelectedValue;
            this.contractsBaseList1[0].OfficesCode = (Guid)drpOffices.SelectedValue;
            this.contractsBaseList1[0].MobileNo = txtMobileNo.Text;
            this.contractsBaseList1[0].StepByStep = chkStepByStep.Checked;
            this.contractsBaseList1[0].SabtSamane = chksabtsamane.Checked;
            this.contractsBaseList1[0].Letter = this.letter_Scan1.Document;
            this.contractsBaseList1[0].userIdUpdate = RASF.General.Classes.Global.CurrentUserCode;//update
            this.contractsBaseList1[0].SendEmail = chkEmail.Checked;
            this.contractsBaseList1[0].SendFax = chkFax.Checked;
            this.contractsBaseList1[0].SendPost = chkPost.Checked;
            this.contractsBaseList1[0].SendTelegram = chkTelegram.Checked;
            this.contractsBaseList1[0].SendWhatsapp = chkWhatsapp.Checked;
            this.contractsBaseList1[0].EstandardAndGomrok = chkEstandardAndGomrok.Checked;
            this.contractsBaseList1[0].Student = chkstudent.Checked;
         //   this.contractsBaseList1[0].Marking = this.chkMarking.Checked;
         //   this.contractsBaseList1[0].Corrosion = this.chkCorrosion.Checked;
         //   this.contractsBaseList1[0].provision = this.chkprovision.Checked;
            this.Executers = (Guid)drpExecuters.SelectedValue;
           

           

            if (this.contractsBaseList1[0].MobileNo.Length > 11 || this.contractsBaseList1[0].MobileNo.Length < 11)
            {
                 System.Windows.Forms.MessageBox.Show("شماره موبایل اشتباه می باشد");                           

            }
            else
            {

                Boolean HasTest = true;

                foreach (RASF.General.Data.Parts_Master parts_master in this.partsMasterList1)
                {
                    if (parts_master.Tests.Count() == 0)
                    {
                        HasTest = false;
                    }
                    parts_master.UserIdUpdate = RASF.General.Classes.Global.CurrentUserCode;//update
                }

                if (DatePickerReceptionDate.SelectedDateTime > DatePickertxtDelivery.SelectedDateTime)
                {
                    System.Windows.Forms.MessageBox.Show("تاریخ تحویل کوچکتر از تاریخ پذیرش می باشد");
                }
                else
                {
                    if (this.contractsBaseList1.list[0].MobileNo != null && this.contractsBaseList1.list[0].Referred != string.Empty && this.contractsBaseList1.list[0].Delivery != null && this.contractsBaseList1.list[0].ReceptionDate != null && this.contractsBaseList1.list[0].UserID != null && this.contractsBaseList1.list[0].SampleSendingTypeCode != null && this.contractsBaseList1.list[0].ReportSendingTypeCode != null && this.contractsBaseList1.list[0].DateOfTestForThePresence != null && HasTest == true && this.contractsBaseList1.list[0].MobileNo != null && partsMasterList1.IsDataCompleted(this.contractsBaseList1.list[0].EnglishReporter) == true)
                   
                    {
                        this.contractsBaseList1.Update();
                        this.partsMasterList1.Update();
                        foreach (RASF.General.Data.Parts_Master parts_master in this.partsMasterList1)
                        {
                            parts_master.Tests.Update();
                        }


                        this.Close();

                        if (this is RASF.Main.Forms.Reception.New_Reciption_EditForAgency)
                        {
                            if (Executers == new Guid("B81C7F01-86AE-4A47-8760-DF2923B203D6"))
                            {
                                Report2.Load(String.Format("{0}\\Report\\SpecialExecuters.mrt", Application.StartupPath));
                                Report2["@Code"] = this.contractsBaseList1.list[0].ContractsCode;
                                Report2.Show();

                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show("قرارداد مورد نظر با شماره " + "  " + this.contractsBaseList1[0].ContractNo + "  " + "اصلاح گردید");
                                report.Load(String.Format("{0}\\Report\\Report1.mrt", Application.StartupPath));
                                report["@Code"] = this.contractsBaseList1.list[0].ContractsCode;
                                report.Show();

                            }


                            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                            Parameter.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", contractsBaseList1[0].ContractsCode));
                            Parameter.Add(new System.Data.SqlClient.SqlParameter("@EditUser", RASF.General.Classes.Global.CurrentUserCode));
                            RASF.General.Lists.Base.BaseList<Object>.FillScalar("EditedContractBase_Update", Parameter);
                           
                        }
                        else
                        {
                            ContractNo = this.contractsBaseList1.GetContractNo();
                            System.Windows.Forms.MessageBox.Show("قرارداد مورد نظر با شماره " + "  " + ContractNo + "  " + "ذخیره گردید");

                            if (Executers == new Guid("B81C7F01-86AE-4A47-8760-DF2923B203D6"))
                            {
                                Report2.Load(String.Format("{0}\\Report\\SpecialExecuters.mrt", Application.StartupPath));
                                Report2["@Code"] = this.contractsBaseList1.list[0].ContractsCode;
                                Report2.Show();

                            }
                            else
                            {
                                report.Load(String.Format("{0}\\Report\\Report1.mrt", Application.StartupPath));
                                report["@Code"] = this.contractsBaseList1.list[0].ContractsCode;
                                report.Show();
                            }
                           
                        }

                        
                        List<System.Data.SqlClient.SqlParameter> ParameterGL = new List<System.Data.SqlClient.SqlParameter>();
                        ParameterGL.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", contractsBaseList1[0].ContractsCode));
                        this.generateLabelList1.Fill(ParameterGL);
                        this.generate_Label1.DoWork(this.generateLabelList1);

                        this.generateLabelList2.spName = "GenerateLabelForAll";
                        List<System.Data.SqlClient.SqlParameter> ParameterGL2 = new List<System.Data.SqlClient.SqlParameter>();
                        ParameterGL2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", contractsBaseList1[0].ContractsCode));
                        this.generateLabelList2.Fill(ParameterGL2);
                        this.generate_Label2.DoWork(this.generateLabelList2);

                        // ((StiOleDbDatabase)report.Dictionary.Databases["Connection"]).ConnectionString = "Integrated Security=False;Data Source=sql-1;Initial Catalog=Test;Password=AliReza23280;User ID=sa";
                        //if (DateMarketing != null)
                        //{
                        //    using (System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage())
                        //    {
                        //        msg.To.Add(new System.Net.Mail.MailAddress(UserEmail));
                        //        msg.From = new System.Net.Mail.MailAddress("marketing@razi-foundation.com");
                        //        msg.Subject = "پذیرش کار جدید";
                        //        msg.Body = "پذیرش کار جدید برای شرکت" + Company + "  " + "به شماره قرارداد" + ContractNo;
                        //        msg.IsBodyHtml = true;
                        //        SendSMS.Classes.Utility.Send(msg);
                        //    }
                        //}

                    //    if (DateMarketingR != DateTime.MinValue)
                    //    {
                    //        using (System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage())
                    //        {
                    //            msg.To.Add(new System.Net.Mail.MailAddress(UserEmailR));
                    //            msg.From = new System.Net.Mail.MailAddress("marketing@razi-foundation.com");
                    //            msg.Subject = "پذیرش کار جدید";
                    //            msg.Body = "پذیرش کار جدید برای شرکت" + CompanyR + "  " + "به شماره قرارداد" + ContractNo;
                    //            msg.IsBodyHtml = true;
                    //            SendSMS.Classes.Utility.Send(msg);
                    //        }
                    //    }

                    //    if (ConnectorEmail != null)
                    //    {
                    //        using (System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage())
                    //        {
                    //            msg.To.Add(new System.Net.Mail.MailAddress(ConnectorEmail));
                    //            msg.From = new System.Net.Mail.MailAddress("marketing@razi-foundation.com");
                    //            msg.Subject = "پذیرش کار جدید";
                    //            msg.Body = "پذیرش کار جدید برای شرکت" + "  " + Company + "به شماره قرارداد" + ContractNo;
                    //            msg.IsBodyHtml = true;
                    //            SendSMS.Classes.Utility.Send(msg);
                    //        }
                    //    }                        
                    //}
                    //else
                    //{
                    //    System.Windows.Forms.MessageBox.Show("اطلاعات کامل نیست");
                    //}

                }
            }

        }
            }

        private void grdPartsMaster_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            switch (e.Column.Key)
            {
                case "SmallPicture":
                    if (dlgSelectPic.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (Parts_Master != null)
                        {
                            Parts_Master.Picture = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 480);
                            Parts_Master.SmallPicture = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 48);
                            if (Parts_Master.RowState != General.Enums.RowState.Added)
                            {
                                Parts_Master.RowState = General.Enums.RowState.Updated;
                            }
                        }
                        else
                        {
                            this.Pic_Array = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 480);
                        }
                    }
                    break;
                case "SmallPicture2":
                    if (dlgSelectPic2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (Parts_Master != null)
                        {
                            Parts_Master.Picture2 = RASF.General.Classes.Utility.ReadPic(dlgSelectPic2.FileName, 480);
                            Parts_Master.SmallPicture2 = RASF.General.Classes.Utility.ReadPic(dlgSelectPic2.FileName, 48);
                            if (Parts_Master.RowState != General.Enums.RowState.Added)
                            {
                                Parts_Master.RowState = General.Enums.RowState.Updated;
                            }
                        }
                        else
                        {
                            this.Pic_Array2 = RASF.General.Classes.Utility.ReadPic(dlgSelectPic2.FileName, 480);
                        }
                    }
                    break;
           
            }
        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= '9' && e.KeyChar >= '0')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void New_Reception_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.letter_Scan1.Dispose();
        }

            
        private void mnuCopy_Click(object sender, EventArgs e)
        {
            if (Parts_Master != null)
            {
                this.CopyTest = Parts_Master.Tests;
                this.mnuPaste.Enabled = true;
            }
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            this.Parts_Master.CopyTest(this.CopyTest);
            this.grdPartsMaster_SelectionChanged(sender, e);
            this.lblPrice.Text = "قیمت کل " + this.partsMasterList1.TotalPrice().ToString() + " ریال";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.companiesBaseList1.Fill();
            this.companiesBaseList2.AddRange(this.companiesBaseList1.list);

            this.grdCompaniesReport.Refetch();
            this.grdCompanisInvoice.Refetch();
        }

        private void dropDownTestForThePresence_SelectedValueChanged(object sender, EventArgs e)
        {
            if (dropDownTestForThePresence.SelectedIndex == 1)
                DatePickertxtDelivery.Enabled = false;
            else
                DatePickertxtDelivery.Enabled = true;
        }

        private void DatePickertxtDelivery_Leave(object sender, EventArgs e)
        {
            if (DatePickertxtDelivery.SelectedDateTime.DayOfWeek == DayOfWeek.Friday)
            {
                DatePickertxtDelivery.BackColor = Color.Red;
                MessageBox.Show("تاریخ تحویل روز جمعه انتخاب شده است", "جمعه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DatePickertxtDelivery.BackColor = Color.White;
            }
        }

        private void DatePickerLetterDate_RightToLeftChanged(object sender, EventArgs e)
        {
           
        }

        private void DatePickerLetterDate_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            if (this.DatePickerLetterDate.SelectedDateTime > DateTime.MinValue)
            {
                this.txtLetterNo.Enabled = true;
            }

        }

        private void chkEnglish_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnglish.Checked == true)
            {
                List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter2.Add(new System.Data.SqlClient.SqlParameter("CompaniesReportCode", CompaniesReportCode));
                Int16 Result = Convert.ToInt16(RASF.General.Lists.BanksList.FillScalar("EnglishName_Select", Parameter2));

                while (Result == 0)
                {
                    MessageBox.Show("اطلاعات را وارد نمایید");
                    RASF.Main.Forms.Reception.CompaniesEnglishReport CompaniesEnglishReport = new Forms.Reception.CompaniesEnglishReport(CompaniesReportCode);
                    CompaniesEnglishReport.ShowDialog();

                    List<System.Data.SqlClient.SqlParameter> Parameter3 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter3.Add(new System.Data.SqlClient.SqlParameter("CompaniesReportCode", CompaniesReportCode));
                    Result = Convert.ToInt16(RASF.General.Lists.BanksList.FillScalar("EnglishName_Select", Parameter3));
                }
            }
        }

        private void txtReferred_TextChanged(object sender, EventArgs e)
        {
            if (txtReferred.Text == string.Empty)
            {
                MessageBox.Show("فیلد مراجعه کننده خالی می باشد");
                txtReferred.BackColor = Color.Red;
            }
        }

        private void chkGhateyat_CheckedChanged(object sender, EventArgs e)
        {

        }


   
    }
}