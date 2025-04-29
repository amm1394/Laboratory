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
    public partial class New_Reciption_Edit__ : RASF.Main.Forms.Reception.New_Reception
    {
        private Int16 ContractNo;
        public New_Reciption_Edit__(Guid contractid)
        {
            InitializeComponent();
            List<System.Data.SqlClient.SqlParameter> Parameters2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", contractid));
            this.contractsBaseList1.Fill(Parameters2);
        }

        private void New_Reciption_Edit_Load(object sender, EventArgs e)
        {
           // txtReson.Enabled = true;
            List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("ContractsBaseCode", this.contractsBaseList1.list[0].ContractsCode));
            this.partsMasterList1.Fill(Parameters1);
            this.grdPartsMaster.Refetch();

            foreach (RASF.General.Data.Parts_Master Parts in this.partsMasterList1.list)
            {
                List<System.Data.SqlClient.SqlParameter> ParametersContractIDPartsMaster = new List<System.Data.SqlClient.SqlParameter>();
                ParametersContractIDPartsMaster.Add(new System.Data.SqlClient.SqlParameter("PartsMasterCode", Parts.Parts_Master_Code));
                Parts.Tests.Fill(ParametersContractIDPartsMaster);
            }

                txtContractNo.Text = this.contractsBaseList1.list[0].ContractNo.ToString();
                DatePickerReceptionDate.SelectedDateTime = this.contractsBaseList1.list[0].ReceptionDate;
                dropDownimmediate.SelectedValue = this.contractsBaseList1.list[0].immediate;
                dropDownTestForThePresence.SelectedValue = this.contractsBaseList1.list[0].TestForThePresence;
                drpOnSiteTesting.SelectedValue = this.contractsBaseList1.list[0].OnSiteTesting;
                dropDownUserID.SelectedValue = this.contractsBaseList1.list[0].UserID;
                dropDownSampleSendingTypeCode.SelectedValue = this.contractsBaseList1.list[0].SampleSendingTypeCode;
             //   dropDownReportSendingTypeCode.SelectedValue = this.contractsBaseList1.list[0].ReportSendingTypeCode;
                //  DatePickerTestForPresence.SelectedDateTime = this.contractsBaseList1.list[0].DateOfTestForThePresence;
                txtReferred.Text = this.contractsBaseList1.list[0].Referred;
                txtExpert.Text = this.contractsBaseList1.list[0].ExpertCompany;
                txtCellExpert.Text = this.contractsBaseList1.list[0].CellPhoneExpert;
                txtNationalCodeReferred.Text = this.contractsBaseList1.list[0].NationalCodeReferred;
                txtLetterNo.Text = this.contractsBaseList1.list[0].LetterNo;
                DatePickerLetterDate.SelectedDateTime = this.contractsBaseList1.list[0].LetterDate;
                txtDescription.Text = this.contractsBaseList1[0].Description;
                chkEnglish.Checked = this.contractsBaseList1[0].EnglishReporter;
                chkPersian.Checked = this.contractsBaseList1[0].PersianReport;
                chkInsPic.Checked = this.contractsBaseList1[0].InsertPicRecieption;
                chkGhateyat.Checked = this.contractsBaseList1[0].Uncertainty;
                drpExecuters.SelectedValue = this.contractsBaseList1[0].Executers;
                drpOffices.SelectedValue = this.contractsBaseList1[0].OfficesCode;
                txtMobileNo.Text = this.contractsBaseList1[0].MobileNo;
                chkStepByStep.Checked = this.contractsBaseList1[0].StepByStep;
                chksabtsamane.Checked = this.contractsBaseList1[0].SabtSamane;
                chkEmail.Checked = this.contractsBaseList1[0].SendEmail;
                chkFax.Checked = this.contractsBaseList1[0].SendFax;
                chkPost.Checked = this.contractsBaseList1[0].SendPost;
                chkTelegram.Checked = this.contractsBaseList1[0].SendTelegram;
                chkWhatsapp.Checked = this.contractsBaseList1[0].SendWhatsapp;
                chkEstandardAndGomrok.Checked = this.contractsBaseList1[0].EstandardAndGomrok;
                chkstudent.Checked = this.contractsBaseList1[0].Student;
                           
                if (this.contractsBaseList1.list[0].Delivery > DateTime.MinValue)
                {
                    DatePickertxtDelivery.SelectedDateTime = this.contractsBaseList1.list[0].Delivery;
                }
                else
                {
                    DatePickertxtDelivery.Enabled = false;
                  
                }

              
                this.AllTab.TabPages[1].Enabled = true;
                this.AllTab.TabPages[2].Enabled = true;

                this.groupBoxInvoice.Text = "نام شرکت جهت صدور صورت حساب  " + this.contractsBaseList1.list[0].Company_Invoice_Name;
                this.groupBoxReport.Text = "نام شرکت جهت صدور گزارش  " + this.contractsBaseList1.list[0].Company_Report_Name;
                CompaniesReportCode = this.contractsBaseList1.list[0].Company_Report;
      
          
            if (DatePickerReceptionDate.SelectedDateTime > DatePickertxtDelivery.SelectedDateTime)
            {
                System.Windows.Forms.MessageBox.Show("تاریخ تحویل اشتباه می باشد");
            }
            else
            {
               this.contractsBaseList1.list[0].RowState = General.Enums.RowState.Updated;
               
            }

            
            ContractNo = (Int16)this.contractsBaseList1.list[0].ContractNo;
            txtContractNo.Text = ContractNo.ToString();

            this.grdPartsMaster_SelectionChanged(this, new EventArgs());
        }

        private void DatePickertxtDelivery_EnabledChanged(object sender, EventArgs e)
        {
            //if (DatePickertxtDelivery.Enabled==false)
            //{
            //     DatePickertxtDelivery.Text = null;
            //   //  this.contractsBaseList1.list[0].Delivery = string.Empty;
            //}
        }

      
    }
}
