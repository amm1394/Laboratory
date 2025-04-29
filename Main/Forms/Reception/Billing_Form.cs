using Stimulsoft.Report.Dictionary;
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
    public partial class Bill_Form : RASF.General.Forms.Base.DockContentForm
    {
        private Guid ContractsCode = Guid.Empty;
        private string To;
        public Bill_Form()
        {
            InitializeComponent();
            ShowpnlUpdate = true;
       
        }

        private void DisCount_Load(object sender, EventArgs e)
        {
            RefreshGrid();

            if (this.contractsBillingList1.Count() > 0)
            {
                this.grdContract.SelectedItems.Clear();
                this.grdContract.SelectedItems.Add(0);
            }
        }

        private void RefreshGrid()
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            this.contractsBillingList1.Fill(Parameters);

            this.grdContract.Refetch();
        }

        private void grdContract_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdContract.CurrentRow != null) && (this.grdContract.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpContracts.Text ="قرارداد" + " " +this.grdContract.CurrentRow.Cells["ContractNo"].Value.ToString();

                if (this.grdContract.SelectedItems.Count > 0)
                {
                    RASF.General.Data.Contracts_Base_Edit Current_Contract = (RASF.General.Data.Contracts_Base_Edit)this.grdContract.SelectedItems[0].GetRow().DataRow;

                    if (Current_Contract != null)
                    {
                        this.ContractsCode = Current_Contract.ContractsCode;
                        List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                        //Parameters.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
                        Parameters.Add(new System.Data.SqlClient.SqlParameter("Code", Current_Contract.ContractsCode));
                        this.masterBillDetailBillList1.Fill(Parameters);
                        this.grdBiill.Refetch();
                    }
                    else
                    {
                        this.masterBillDetailBillList1.Clear();
                       // this.grdBiill.Refetch();
                        this.ContractsCode = Guid.Empty;
                    }
                }
                else
                {
                    this.masterBillDetailBillList1.Clear();
                    this.grdBiill.Refetch();
                    this.ContractsCode = Guid.Empty;
                }
            }
            else
            {
                this.grpContracts.Text = "";
            }
        }

       
        private void grdBiill_CurrentCellChanged(object sender, EventArgs e)
        {
            this.masterBillDetailBillList1.UpdateRow();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (ContractsCode != Guid.Empty)
            {

                this.masterBillDetailBillList1.Update();

             

                Report2.Load(String.Format("{0}\\Report\\{1}", Application.StartupPath, this.masterBillDetailBillList1.Survey(ContractsCode)));
                Report2["@Code"] = ContractsCode;
                // Report2["@FinancialYear"] = RASF.General.Classes.Global.FinancialYear;
                Report2.Show();
                            

                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", ContractsCode));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@UserName", RASF.General.Classes.Global.CurrentUserName));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@Description", "صدور صورت حساب"));
                RASF.General.Lists.Base.BaseList<Object>.FillScalar("DescForEditContractBase_Insert", Parameter);

                //ایمیل صورت حساب
                SendSMS.Classes.SurvayBillForEmailBillList SurvayBillInfo = new SendSMS.Classes.SurvayBillForEmailBillList();
                SurvayBillInfo.Fill(RASF.General.Classes.Global.FinancialYear, Convert.ToInt32((int)this.grdContract.CurrentRow.Cells["ContractNo"].Value));


                //14001023
                //SendSMS.Classes.Bills Bills = new SendSMS.Classes.Bills();
                //Bills.ContractNo = Convert.ToInt32((int)this.grdContract.CurrentRow.Cells["ContractNo"].Value);
                //Bills.FinancialYear = RASF.General.Classes.Global.FinancialYear;
                //Bills.MakeBill();

                //Bills.ContractNo = Convert.ToInt32((int)this.grdContract.CurrentRow.Cells["ContractNo"].Value);
                //Bills.FinancialYear = RASF.General.Classes.Global.FinancialYear;

                List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.grdContract.CurrentRow.Cells["ContractsCode"].Value));
                To = RASF.General.Lists.SendEmailList.FillScalar("SendEmail_Select", Parameter2).ToString();

              //  if (SurvayBillInfo.list[0].Check == 0)
              //  {
                    //using (Aspose.Email.Mail.MailMessage message = new Aspose.Email.Mail.MailMessage())
                    //{
                    //    message.From = "Invoice@razi-foundation.com";
                    //    message.To = To;
                    //    message.Subject = string.Format("صورت حساب قرارداد {0}", this.grdContract.CurrentRow.Cells["ContractNo"].Value.ToString());
                    //    // message.HtmlBody = string.Format("<p dir={0}> مشتری گرامی <br />با سلام؛<br /> احتراما خدمات درخواستی آن شرکت محترم؛ طی نامه شماره {1 مورخ {2 آن شرکت محترم ، قرارداد پذیرش شده در این بنیاد با شماره پیگری {3 انجام پذیرفته و گزارش نتایج آزمون آماده تحویل می باشد . همچنین صورت حساب خدمات آزمایشگاهی ارائه شده به پیوست ارسال می گردد.}}} </p>", "rtl", this.sendEmailOfBillsList1[0].LetterNo, this.sendEmailOfBillsList1[0].LetterDate, this.txtSearch.Text);
                    //    message.HtmlBody = String.Format("<p dir={0}>مشتری گرامی <br />با سلام؛<br /> احتراما خدمات درخواستی آن شرکت محترم؛ طی نامه شماره    {1}  مورخ      {2} ، قرارداد پذیرش شده در این بنیاد با شماره پیگیری {3}، انجام پذیرفته و گزارش نتایج آزمون آماده تحویل می باشد. همچنین صورت حساب خدمات آزمایشگاهی ارائه شده به پیوست ارسال می گردد.</p>", "rtl", this.grdContract.CurrentRow.Cells["LetterNo"].Value.ToString(), this.grdContract.CurrentRow.Cells["LetterDate"].Value.ToString(), this.grdContract.CurrentRow.Cells["ContractNo"].Value.ToString());
                    //    message.Attachments.Add(new Aspose.Email.Mail.Attachment(Bills.MakeBill(), string.Format("صورت حساب قرارداد {0}.pdf", this.grdContract.CurrentRow.Cells["ContractNo"].Value.ToString())));
                    //    Utility.SendMailInvoice(message);

                    //    MessageBox.Show("صورت حساب با موفقیت ارسال شد");
                    //}
           //     }

           

                //if (this.grdContract.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record)
                ////if (this.contractsBillingList1.Count() > 0)
                //{
                    //this.grdContract.SelectedItems.Clear();
                    //this.grdContract.SelectedItems.Add(0);
                //}

             
            }

            //List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            //Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            //this.contractsBillingList1.Fill(Parameters);
            //this.grdContract.Refetch();

            RefreshGrid();

           

          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RefreshGrid();
            if (this.contractsBillingList1.Count() > 0)
            {
                this.grdContract.SelectedItems.Clear();
                this.grdContract.SelectedItems.Add(0);
            }
        }

        private void grdContract_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (this.grdContract.SelectedItems.Count > 0)
            {
                RASF.General.Data.Contracts_Base_Edit CurrentRow = (RASF.General.Data.Contracts_Base_Edit)this.grdContract.SelectedItems[0].GetRow().DataRow;
                CurrentRow.RowState = General.Enums.RowState.Updated;
                this.contractsBillingList1.Update();
            }
        }

       
    }
}
