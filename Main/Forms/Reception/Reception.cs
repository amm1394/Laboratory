using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using System.

namespace RASF.Main.Forms.Reception
{
    public partial class Reception : RASF.General.Forms.Base.DockContentForm
    {
        protected RASF.General.Data.Contracts_Base Contracts_Base = new General.Data.Contracts_Base();
        protected RASF.General.Data.Parts_Master Parts_Master1 = new General.Data.Parts_Master();
        protected Int16 TotalPrice;
        protected Guid CompanyInvoice;
        protected Guid CompanyReport;
        protected RASF.General.Data.Parts_Master LastRow;
        protected int ContractNo;
        protected Guid partstestMasterCode;

        public Reception()
        {
            InitializeComponent();
            this.Contracts_Base.ContractsCode = partsMasterList1.GetId();
        }

        private void Reception_Load(object sender, EventArgs e)
        {
            if (DesignMode == false)
            {
                try
                {
                    this.grdPartsMaster.RemoveBindingContextChanged();
                    this.labList1.Fill();
                    this.mainTestList1.Fill();
                    this.companiesBaseList1.Fill();
                    this.companiesActivityTypeList1.Fill();

                    List<System.Data.SqlClient.SqlParameter> Parameters2 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameters2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.Contracts_Base.ContractsCode));
                    this.contractsBaseList1.Fill(Parameters2);

                    this.companiesBaseList2.AddRange(this.companiesBaseList1.list);
                    this.yes_NoList1.Fill();
                    this.userList1.Fill();
                    this.sampleSendingTypeList1.Fill();
                    this.reportSendingTypeList1.Fill();
                    
                    grdCompaniesReport.Refetch();
                    grdCompanisInvoice.Refetch();
                    grdPartsMaster.Refetch();

                    dropDownUserID.DataSource = userList1;
                    dropDownUserID.DisplayMember = "UserName";
                    dropDownUserID.ValueMember = "UserId";

                    dropDownSampleSendingTypeCode.DataSource = sampleSendingTypeList1;
                    dropDownSampleSendingTypeCode.DisplayMember = "Name";
                    dropDownSampleSendingTypeCode.ValueMember = "Code";

                    dropDownReportSendingTypeCode.DataSource = reportSendingTypeList1;
                    dropDownReportSendingTypeCode.DisplayMember = "Name";
                    dropDownReportSendingTypeCode.ValueMember = "Code";

                    dropDownimmediate.DataSource = yes_NoList1; ;
                    dropDownimmediate.DisplayMember = "YesNo";
                    dropDownimmediate.ValueMember = "Code";

                    dropDownTestForThePresence.DataSource = yes_NoList1; ;
                    dropDownTestForThePresence.DisplayMember = "YesNo";
                    dropDownTestForThePresence.ValueMember = "Code";


                    General.Classes.Utility.Create_DropDown(this.grdPartsMaster.RootTable.Columns["Destruct"], this.yes_NoList1, "Code", "YesNo");
                    General.Classes.Utility.Create_DropDown(this.grdPartsMaster.RootTable.Columns["FeBase"], this.yes_NoList1, "Code", "YesNo");
                    General.Classes.Utility.Create_DropDown(this.grdPartsMaster.RootTable.Columns["Void"], this.yes_NoList1, "Code", "YesNo");
                    General.Classes.Utility.Create_DropDown(this.grdPartsMaster.RootTable.Columns["IsLarge"], this.yes_NoList1, "Code", "YesNo");

                    General.Classes.Utility.Create_DropDown(this.grdCompaniesReport.RootTable.Columns["ActivityCode"], this.companiesActivityTypeList1, "ActivityCode", "ActivityName");
                    General.Classes.Utility.Create_DropDown(this.grdCompanisInvoice.RootTable.Columns["ActivityCode"], this.companiesActivityTypeList1, "ActivityCode", "ActivityName");


                    this.grdPartsMaster.RootTable.Columns["Destruct"].DefaultValue = this.yes_NoList1[0].Code;
                    this.grdPartsMaster.RootTable.Columns["FeBase"].DefaultValue = this.yes_NoList1[0].Code;
                    this.grdPartsMaster.RootTable.Columns["Void"].DefaultValue = this.yes_NoList1[1].Code;
                    this.grdPartsMaster.RootTable.Columns["IsLarge"].DefaultValue = this.yes_NoList1[0].Code;

                    this.grdCompaniesReport.RootTable.Columns["ActivityCode"].DefaultValue = this.companiesActivityTypeList1[0].ActivityCode;
                    this.grdCompanisInvoice.RootTable.Columns["ActivityCode"].DefaultValue = this.companiesActivityTypeList1[0].ActivityCode;


                    this.dropDownUserID.SelectedIndex = 0;
                    this.dropDownTestForThePresence.SelectedIndex = 0;
                    this.dropDownSampleSendingTypeCode.SelectedIndex = 0;
                    this.dropDownReportSendingTypeCode.SelectedIndex = 0;
                    this.dropDownimmediate.SelectedIndex = 0;


                    List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("FINANCAILYEAR", RASF.General.Classes.Global.FinancialYear));
                    this.masterteststatusList_Main1.Fill(Parameters);



                    DatePickerReceptionDate.SelectedDateTime = System.DateTime.Now;
                    DatePickertxtDelivery.SelectedDateTime = System.DateTime.Now.AddDays(1);
                    DatePickerTestForPresence.SelectedDateTime = System.DateTime.Now.AddDays(1);

                    foreach (RASF.General.Data.Laboratory Lab in this.labList1.GetList())
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
                            TestControl.MASTERTESTSTATUSList = masterteststatusList1;
                            TestControl.Dock = DockStyle.Top;
                            TabPage.Controls.Add(TestControl);

                        }
                        this.tabLab.TabPages.Add(TabPage);
                    }

                    List<System.Data.SqlClient.SqlParameter> ParametersContractID = new List<System.Data.SqlClient.SqlParameter>();
                    ParametersContractID.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.Contracts_Base.ContractsCode));
                    this.contractsBaseList1.Fill(ParametersContractID);

                    ContractNo = this.contractsBaseList1.GetContractNo();
                    txtContractNo.Text = Convert.ToString(ContractNo);
                    TabPgGeneral.Enabled = false;
                    TabPgSample.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void grdCompaniesright_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            CompanyInvoice = (Guid)(this.grdCompanisInvoice.CurrentRow.Cells["CompaniesCode"].Value);
            CompanyReport = (Guid)(this.grdCompaniesReport.CurrentRow.Cells["CompaniesCode"].Value);
            this.groupBoxInvoice.Text ="شرکت" +" " + this.grdCompanisInvoice.CurrentRow.Cells["CompanyName"].Value.ToString() + " " + "جهت صدور صورت حساب";
            Contracts_Base.Company_Invoice = new Guid(this.grdCompanisInvoice.CurrentRow.Cells["CompaniesCode"].Value.ToString());
            if (Contracts_Base.Company_Report == new Guid("00000000-0000-0000-0000-000000000000"))
            {
                Contracts_Base.Company_Report = Contracts_Base.Company_Invoice;
                this.groupBoxReport.Text = "شرکت" + " " + this.grdCompanisInvoice.CurrentRow.Cells["CompanyName"].Value.ToString() + " " + "جهت صدور گزارش";
            }
            TabPgSample.Enabled = true;
            TabPgGeneral.Enabled = true;

        }

        private void grdCompaniesleft_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            CompanyReport = (Guid)(this.grdCompaniesReport.CurrentRow.Cells["CompaniesCode"].Value);
            CompanyInvoice = (Guid)(this.grdCompanisInvoice.CurrentRow.Cells["CompaniesCode"].Value);
            this.groupBoxReport.Text = "شرکت" + " " + this.grdCompaniesReport.CurrentRow.Cells["CompanyName"].Value.ToString() + " " + "جهت صدور گزارش";
            Contracts_Base.Company_Report = new Guid(this.grdCompaniesReport.CurrentRow.Cells["CompaniesCode"].Value.ToString());
            if (Contracts_Base.Company_Invoice == new Guid("00000000-0000-0000-0000-000000000000"))
            {
                Contracts_Base.Company_Invoice = Contracts_Base.Company_Report;
                this.groupBoxInvoice.Text = "شرکت" +" " + this.grdCompaniesReport.CurrentRow.Cells["CompanyName"].Value.ToString() + " " + "جهت صدور صورت حساب";
            }
            TabPgSample.Enabled = true;
            TabPgGeneral.Enabled = true;
        }

        protected virtual void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
            this.grdPartsMaster_SelectionChanged(sender, e);

            this.Contracts_Base.Delivery = DatePickertxtDelivery.SelectedDateTime;
            this.Contracts_Base.ReceptionDate = DatePickerReceptionDate.SelectedDateTime;
            this.Contracts_Base.immediate = Convert.ToByte(dropDownimmediate.SelectedValue);
            this.Contracts_Base.TestForThePresence = Convert.ToByte(dropDownTestForThePresence.SelectedValue);
            this.Contracts_Base.UserID = (Guid)(dropDownUserID.SelectedValue);
            this.Contracts_Base.SampleSendingTypeCode = (Guid)(dropDownSampleSendingTypeCode.SelectedValue);
            this.Contracts_Base.ReportSendingTypeCode = (Guid)(dropDownReportSendingTypeCode.SelectedValue);
            this.Contracts_Base.DateOfTestForThePresence = DatePickerTestForPresence.SelectedDateTime;
            this.Contracts_Base.ContractYear = RASF.General.Classes.Global.FinancialYear;

            this.contractsBaseList1.Add(this.Contracts_Base);

            foreach (RASF.General.Data.Parts_Master Parts_Master in this.partsMasterList1)
            {
                Parts_Master.ContractsBaseCode = this.Contracts_Base.ContractsCode;
            }

            if (this.Contracts_Base.Delivery != null && this.Contracts_Base.ReceptionDate != null && this.Contracts_Base.UserID != null && this.Contracts_Base.SampleSendingTypeCode != null && this.Contracts_Base.ReportSendingTypeCode != null && this.Contracts_Base.DateOfTestForThePresence != null)
            {
                this.contractsBaseList1.Update();
                this.partsMasterList1.Update();

                foreach (RASF.General.Data.Parts_Master parts_master in this.partsMasterList1)
                {
                    foreach (RASF.General.Data.MasterTestStatus row in parts_master.Tests)
                    {
                        row.PartsMasterCode = parts_master.Parts_Master_Code;
                        row.PartsTestMasterCode = this.partsMasterList1.GetId();
                    }
                    parts_master.Tests.Update();
                }
                this.Close();
                System.Windows.Forms.MessageBox.Show("قرارداد مورد نظر با شماره " + "  " + ContractNo + "  " + "ذخیره گردید");

                report.Load(String.Format("{0}\\Report\\Report1.mrt",Application.StartupPath));
                report["@Code"] = Contracts_Base.ContractsCode;
                report.Show();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("اطلاعات را به طور کامل وارد نمایید");
            }

        }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void grdPartsMaster_SelectionChanged(object sender, EventArgs e)
        {
            if (LastRow != null)
            {
                LastRow.Tests = new General.Lists.MasterTestStatusList();
                foreach (Janus.Windows.UI.Tab.UITabPage Page in this.tabLab.TabPages)
                {
                    foreach (RASF.Main.Controls.Reception.Test_Control TestControl in Page.Controls)
                    {
                        //LastRow.Tests.AddRange(TestControl.GetTest().list);
                        //LastRow.Tests.deletedlist.AddRange(TestControl.GetTest().deletedlist);
                        TestControl.Reset();

                        if (grdPartsMaster.CurrentRow.DataRow != null)
                        {
                            TestControl.Set(((RASF.General.Data.Parts_Master)grdPartsMaster.CurrentRow.DataRow).Tests.Where(Row => Row.MainTestCode == TestControl.MainCode).ToList());
                        }
                    }
                }
            }
            LastRow = (RASF.General.Data.Parts_Master)grdPartsMaster.CurrentRow.DataRow;
        }

        private void dropDownTestForThePresence_SelectedValueChanged(object sender, EventArgs e)
        {
            if (dropDownTestForThePresence.SelectedIndex == 1)
                DatePickerTestForPresence.Enabled = true;
            else
                DatePickerTestForPresence.Enabled = false;
        }

        private void grdPartsMaster_RowCountChanged_1(object sender, EventArgs e)
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

        private void grdPartsMaster_RecordAdded(object sender, EventArgs e)
        {
            LastRow = (RASF.General.Data.Parts_Master)this.grdPartsMaster.SelectedItems[0].GetRow().DataRow;
        }
    }
}
