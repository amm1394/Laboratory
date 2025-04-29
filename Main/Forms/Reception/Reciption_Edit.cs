using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reception
{
    public partial class Reciption_Edit : RASF.Main.Forms.Reception.Reception
    {
        public Reciption_Edit(Guid contractid)
        {
            InitializeComponent();
            this.Contracts_Base.ContractsCode = contractid;
        }

        private void Reciption_Edit_Load(object sender, EventArgs e)
        {
            try
            {
                this.Contracts_Base = this.contractsBaseList1.list[0];

                List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
                Parameters1.Add(new System.Data.SqlClient.SqlParameter("ContractsBaseCode", this.Contracts_Base.ContractsCode));
                this.partsMasterList1.Fill(Parameters1);
                this.grdPartsMaster.Refetch();

                this.Parts_Master1 = this.partsMasterList1.list[0];
                LastRow = (RASF.General.Data.Parts_Master)this.grdPartsMaster.SelectedItems[0].GetRow().DataRow;

                foreach (RASF.General.Data.Parts_Master Parts in this.partsMasterList1.list)
                {
                    List<System.Data.SqlClient.SqlParameter> ParametersContractIDPartsMaster = new List<System.Data.SqlClient.SqlParameter>();
                    ParametersContractIDPartsMaster.Add(new System.Data.SqlClient.SqlParameter("PartsMasterCode", Parts.Parts_Master_Code));
                    Parts.Tests.Fill(ParametersContractIDPartsMaster);
                }

                foreach (Janus.Windows.UI.Tab.UITabPage Page in this.tabLab.TabPages)
                {
                    foreach (RASF.Main.Controls.Reception.Test_Control TestControl in Page.Controls)
                    {
                        TestControl.Reset();
                        if (grdPartsMaster.CurrentRow.DataRow != null)
                        {
                            TestControl.Set(((RASF.General.Data.Parts_Master)grdPartsMaster.CurrentRow.DataRow).Tests.Where(Row => Row.MainTestCode == TestControl.MainCode).ToList());
                        }
                    }
                }

                txtContractNo.Text = this.Contracts_Base.ContractNo.ToString();
                DatePickertxtDelivery.SelectedDateTime = this.Contracts_Base.Delivery;
                DatePickerReceptionDate.SelectedDateTime = this.Contracts_Base.ReceptionDate;
                dropDownimmediate.SelectedValue = this.Contracts_Base.immediate;
                dropDownTestForThePresence.SelectedValue = this.Contracts_Base.TestForThePresence;
                dropDownUserID.SelectedValue = this.Contracts_Base.UserID;
                dropDownSampleSendingTypeCode.SelectedValue = this.Contracts_Base.SampleSendingTypeCode;
                dropDownReportSendingTypeCode.SelectedValue = this.Contracts_Base.ReportSendingTypeCode;
                DatePickerTestForPresence.SelectedDateTime = this.Contracts_Base.DateOfTestForThePresence;
                this.Contracts_Base.ContractYear = RASF.General.Classes.Global.FinancialYear;

                //this.grdCompanisInvoice.CurrentRow.Cells["Company_Invoice"].Value = RASF.General.Classes.Global.Company_Invoice;
                //this.grdCompaniesReport.CurrentRow.Cells["Company_Report"].Value = RASF.General.Classes.Global.Company_Report;

                //  this.grdCompanisInvoice.


                this.AllTab.TabPages[1].Enabled = true;
                this.AllTab.TabPages[2].Enabled = true;

                //this.groupBoxInvoice.Text = "شرکت" + " " + this.grdCompanisInvoice.CurrentRow.Cells["CompanyName"].Value.ToString() + " " + "جهت صدور صورت حساب";
                //this.groupBoxReport.Text = "شرکت" + " " + this.grdCompaniesReport.CurrentRow.Cells["CompanyName"].Value.ToString() + " " + "جهت صدور گزارش";

                ContractNo = this.Contracts_Base.ContractNo;
                txtContractNo.Text = Convert.ToString(ContractNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void btnSave_Click(object sender, EventArgs e)
        {
            this.Contracts_Base.Delivery = DatePickertxtDelivery.SelectedDateTime;
            this.Contracts_Base.ReceptionDate = DatePickerReceptionDate.SelectedDateTime;
            this.Contracts_Base.immediate = Convert.ToByte(dropDownimmediate.SelectedValue);
            this.Contracts_Base.TestForThePresence = Convert.ToByte(dropDownTestForThePresence.SelectedValue);
            this.Contracts_Base.UserID = (Guid)(dropDownUserID.SelectedValue);
            this.Contracts_Base.SampleSendingTypeCode = (Guid)(dropDownSampleSendingTypeCode.SelectedValue);
            this.Contracts_Base.ReportSendingTypeCode = (Guid)(dropDownReportSendingTypeCode.SelectedValue);
            this.Contracts_Base.DateOfTestForThePresence = DatePickerTestForPresence.SelectedDateTime;
            this.Contracts_Base.ContractYear = RASF.General.Classes.Global.FinancialYear;

            if (this.Contracts_Base.Delivery != null && this.Contracts_Base.ReceptionDate != null && this.Contracts_Base.UserID != null && this.Contracts_Base.SampleSendingTypeCode != null && this.Contracts_Base.ReportSendingTypeCode != null && this.Contracts_Base.DateOfTestForThePresence != null)
            {
                this.contractsBaseList1.Clear();
                this.contractsBaseList1.Add(this.Contracts_Base, General.Enums.RowState.Updated);
                this.contractsBaseList1.Update();

                foreach (RASF.General.Data.Parts_Master Parts_Master in this.partsMasterList1)
                {
                    Parts_Master.ContractsBaseCode = this.Contracts_Base.ContractsCode;
                }

                this.partsMasterList1.Update();


                foreach (RASF.General.Data.Parts_Master parts_master in this.partsMasterList1)
                {
                    foreach (RASF.General.Data.MasterTestStatus row in parts_master.Tests)
                    {
                        row.PartsMasterCode = parts_master.Parts_Master_Code;
                        if (row.RowState == General.Enums.RowState.Added)
                        {
                            row.PartsTestMasterCode = this.partsMasterList1.GetId();
                        }
                        else if (row.RowState == General.Enums.RowState.Original)
                        {
                            row.RowState = General.Enums.RowState.Updated;
                        }
                    }
                    parts_master.Tests.Update();
                }

                this.Close();
                System.Windows.Forms.MessageBox.Show("قرارداد مورد نظر با شماره " + "  " + ContractNo + "  " + "اصلاح گردید");

                report.Load(String.Format("{0}\\Report\\Report1.mrt", Application.StartupPath));
                report["@Code"] = Contracts_Base.ContractsCode;
                report.Show();
            }
        }
    }
}
