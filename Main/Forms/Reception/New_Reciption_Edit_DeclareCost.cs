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
    public partial class New_Reciption_Edit_DeclareCost : RASF.Main.Forms.Reception.New_ReceptionDeclareCost
    {
        private Int16 ContractNo;
        public New_Reciption_Edit_DeclareCost(Guid contractid)
        {
            InitializeComponent();
            List<System.Data.SqlClient.SqlParameter> Parameters2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", contractid));
            this.contractsBaseDeclareCostList1.Fill(Parameters2);
        }

        private void New_Reciption_Edit_DeclareCost_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("ContractsBaseCode", this.contractsBaseDeclareCostList1.list[0].ContractsCode));
            this.parts_Master_DeclareCostList1.Fill(Parameters1);
            this.grdPartsMaster.Refetch();

            foreach (RASF.General.Data.Parts_MasterDeclareCost Parts in this.parts_Master_DeclareCostList1.list)
            {
                List<System.Data.SqlClient.SqlParameter> ParametersContractIDPartsMaster = new List<System.Data.SqlClient.SqlParameter>();
                ParametersContractIDPartsMaster.Add(new System.Data.SqlClient.SqlParameter("PartsMasterCode", Parts.Parts_Master_Code));
                Parts.Tests.Fill(ParametersContractIDPartsMaster);
            }

            txtContractNo.Text = this.contractsBaseDeclareCostList1.list[0].ContractNo.ToString();
            DatePickerReceptionDate.SelectedDateTime = this.contractsBaseDeclareCostList1.list[0].ReceptionDate;
            dropDownimmediate.SelectedValue = this.contractsBaseDeclareCostList1.list[0].immediate;
            dropDownTestForThePresence.SelectedValue = this.contractsBaseDeclareCostList1.list[0].TestForThePresence;
            dropDownUserID.SelectedValue = this.contractsBaseDeclareCostList1.list[0].UserID;
            dropDownSampleSendingTypeCode.SelectedValue = this.contractsBaseDeclareCostList1.list[0].SampleSendingTypeCode;
            dropDownReportSendingTypeCode.SelectedValue = this.contractsBaseDeclareCostList1.list[0].ReportSendingTypeCode;
            //  DatePickerTestForPresence.SelectedDateTime = this.contractsBaseList1.list[0].DateOfTestForThePresence;
            txtReferred.Text = this.contractsBaseDeclareCostList1.list[0].Referred;
            txtLetterNo.Text = this.contractsBaseDeclareCostList1.list[0].LetterNo;
            DatePickerLetterDate.SelectedDateTime = this.contractsBaseDeclareCostList1.list[0].LetterDate;
            txtDescription.Text = this.contractsBaseDeclareCostList1[0].Description;
            chkEnglish.Checked = this.contractsBaseDeclareCostList1[0].EnglishReporter;
            chkPersian.Checked = this.contractsBaseDeclareCostList1[0].PersianReport;
            chkInsPic.Checked = this.contractsBaseDeclareCostList1[0].InsertPicRecieption;
            chkGhateyat.Checked = this.contractsBaseDeclareCostList1[0].Uncertainty;
            drpExecuters.SelectedValue = this.contractsBaseDeclareCostList1[0].Executers;
            drpOffices.SelectedValue = this.contractsBaseDeclareCostList1[0].OfficesCode;
            txtMobileNo.Text = this.contractsBaseDeclareCostList1[0].MobileNo;
            chkStepByStep.Checked = this.contractsBaseDeclareCostList1[0].StepByStep;
            chksabtsamane.Checked = this.contractsBaseDeclareCostList1[0].SabtSamane;
            chkEmail.Checked = this.contractsBaseDeclareCostList1[0].SendEmail;
            chkFax.Checked = this.contractsBaseDeclareCostList1[0].SendFax;
            chkPost.Checked = this.contractsBaseDeclareCostList1[0].SendPost;

            if (this.contractsBaseDeclareCostList1.list[0].Delivery > DateTime.MinValue)
            {
                DatePickertxtDelivery.SelectedDateTime = this.contractsBaseDeclareCostList1.list[0].Delivery;
            }
            else
            {
                DatePickertxtDelivery.Enabled = false;

            }


            this.AllTab.TabPages[1].Enabled = true;
            this.AllTab.TabPages[2].Enabled = true;

            this.groupBoxInvoice.Text = "نام شرکت جهت صدور صورت حساب  " + this.contractsBaseDeclareCostList1.list[0].Company_Invoice_Name;
            this.groupBoxReport.Text = "نام شرکت جهت صدور گزارش  " + this.contractsBaseDeclareCostList1.list[0].Company_Report_Name;
            CompaniesReportCode = this.contractsBaseDeclareCostList1.list[0].Company_Report;


            if (DatePickerReceptionDate.SelectedDateTime > DatePickertxtDelivery.SelectedDateTime)
            {
                System.Windows.Forms.MessageBox.Show("تاریخ تحویل اشتباه می باشد");
            }
            else
            {
                this.contractsBaseDeclareCostList1.list[0].RowState = General.Enums.RowState.Updated;

            }


            ContractNo = (Int16)this.contractsBaseDeclareCostList1.list[0].ContractNo;
            txtContractNo.Text = ContractNo.ToString();

            this.grdPartsMaster_SelectionChanged(this, new EventArgs());
        }
    }
}
