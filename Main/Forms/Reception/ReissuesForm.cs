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
    public partial class ReissuesForm : RASF.General.Forms.Base.DockContentForm
    {
        private Guid ContractsCode = Guid.Empty;
        private Boolean InformalFactor;
        private Boolean AcceptServiceTopic;
        private Boolean Grant;
        private Guid MasterBillsCode;
        private Int64 BefAmount;
        private Int64 AftAmount;
        private int BillNo;
        private int ContractNo;
        private string To;
        public ReissuesForm()
        {
            InitializeComponent();
            this.pnlButton.Visible = true;
        }

        private void ReissuesForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            this.contractsReissuesList1.Fill();
            this.grdContracts.Refetch();
        }

        private void grdContracts_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdContracts.CurrentRow != null) && (this.grdContracts.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpContracts.Text = String.Format("قرارداد {0}", this.grdContracts.CurrentRow.Cells["ContractNo"].Value);
            }
            else
            {
                this.grpContracts.Text = "";
            }


            if (this.grdContracts.SelectedItems.Count > 0)
            {
                RASF.General.Data.Contracts_Base_Edit Current_Contract = (RASF.General.Data.Contracts_Base_Edit)this.grdContracts.SelectedItems[0].GetRow().DataRow;

                if (Current_Contract != null)
                {
                    InformalFactor = Current_Contract.InformalFactor;
                    AcceptServiceTopic = Current_Contract.AcceptServiceTopic;
                    Grant = Current_Contract.Grant;
                    this.ContractsCode = Current_Contract.ContractsCode;
                    this.MasterBillsCode = Current_Contract.MasterBillsCode;
                    this.BillNo = Current_Contract.BillNo;
                    this.ContractNo = Current_Contract.ContractNo;
                    List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("Code", Current_Contract.ContractsCode));
                    this.billReissuesList1.Fill(Parameters);

                    this.grdBill.Refetch();
                }
                else
                {
                    this.billReissuesList1.Clear();
                   // this.grdBill.Refetch();
                    this.ContractsCode = Guid.Empty;
                }
            }
            else
            {
                this.billReissuesList1.Clear();
                this.grdBill.Refetch();
                this.ContractsCode = Guid.Empty;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ContractsCode != Guid.Empty)
            {
                List<System.Data.SqlClient.SqlParameter> BefAmount = new List<System.Data.SqlClient.SqlParameter>();
                BefAmount.Add(new System.Data.SqlClient.SqlParameter("@MasterBillsCode", this.MasterBillsCode));
                this.BefAmount = (Int64) RASF.General.Lists.Base.BaseList<Object>.FillScalar("BillAmount_Select", BefAmount);

                this.billReissuesList1.Update();

                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", ContractsCode));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@UserName", RASF.General.Classes.Global.CurrentUserName));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@Description", "صدور مجدد صورت حساب"));
                RASF.General.Lists.Base.BaseList<Object>.FillScalar("DescForEditContractBase_Insert", Parameter);

                if (this.InformalFactor == false)
                {
                    if (this.Grant == true)
                    {
                        Report2.Load(String.Format("{0}\\Report\\BillReissuesForGrant.mrt", Application.StartupPath));
                        
                    }
                    else  if (this.AcceptServiceTopic == true)
                    {
                        Report2.Load(String.Format("{0}\\Report\\BillReissuesServiceTopic.mrt", Application.StartupPath));
                    }
                    else
                    {
                        Report2.Load(String.Format("{0}\\Report\\BillReissues.mrt", Application.StartupPath));
                    }
                }
                else
                {
                    Report2.Load(String.Format("{0}\\Report\\BillReissues-Informal.mrt", Application.StartupPath));
                }
                Report2["@Code"] = ContractsCode;
                Report2["@FinancialYear"] = RASF.General.Classes.Global.FinancialYear;
                Report2.Show();

                List<System.Data.SqlClient.SqlParameter> AftAmount = new List<System.Data.SqlClient.SqlParameter>();
                AftAmount.Add(new System.Data.SqlClient.SqlParameter("@MasterBillsCode", this.MasterBillsCode));
                this.AftAmount = (Int64)RASF.General.Lists.Base.BaseList<Object>.FillScalar("BillAmount_Select", AftAmount);

                if(this.BefAmount != this.AftAmount)
                {
                    using (System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage())
                    {
//                        msg.To.Add(new System.Net.Mail.MailAddress("nmossayebi@razi-foundation.com"));
                        //msg.From = new System.Net.Mail.MailAddress("invoice@razi-foundation.com");
                        //msg.Subject = "تغییر صورت حساب";
                        //msg.Body = "مبلغ شماره صورت حساب" + "  " + BillNo + "  " + "به شماره پیگیری" + "  " + ContractNo + " " + "تغییر کرد";
                        //msg.IsBodyHtml = true;
                        //SendSMS.Classes.Utility.Send(msg);
                    }

                    List<System.Data.SqlClient.SqlParameter> ChengeForAmountOfBill = new List<System.Data.SqlClient.SqlParameter>();
                    ChengeForAmountOfBill.Add(new System.Data.SqlClient.SqlParameter("@MasterBillsCode", this.MasterBillsCode));
                    ChengeForAmountOfBill.Add(new System.Data.SqlClient.SqlParameter("@UserName", RASF.General.Classes.Global.CurrentUserName));
                    ChengeForAmountOfBill.Add(new System.Data.SqlClient.SqlParameter("@BefAmount", this.BefAmount));
                    ChengeForAmountOfBill.Add(new System.Data.SqlClient.SqlParameter("@AftAmount", this.AftAmount));
                    RASF.General.Lists.Base.BaseList<Object>.FillScalar("ChengeForAmountOfBill_Insert", ChengeForAmountOfBill);
                }

                SendSMS.Classes.SurvayBillForEmailBillList SurvayBillInfo = new SendSMS.Classes.SurvayBillForEmailBillList();
                SurvayBillInfo.Fill(RASF.General.Classes.Global.FinancialYear, Convert.ToInt32((int)this.grdContracts.CurrentRow.Cells["ContractNo"].Value));

                SendSMS.Classes.Bills Bills = new SendSMS.Classes.Bills();
                Bills.ContractNo = Convert.ToInt32((int)this.grdContracts.CurrentRow.Cells["ContractNo"].Value);
                Bills.FinancialYear = RASF.General.Classes.Global.FinancialYear;
                Bills.MakeBill();

                //Bills.ContractNo = Convert.ToInt32((int)this.grdContract.CurrentRow.Cells["ContractNo"].Value);
                //Bills.FinancialYear = RASF.General.Classes.Global.FinancialYear;

                List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.grdContracts.CurrentRow.Cells["ContractsCode"].Value));
                To = RASF.General.Lists.SendEmailList.FillScalar("SendEmail_Select", Parameter2).ToString();

                if (SurvayBillInfo.list[0].Check == 0)
                {
                    using (System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage())
                    {
                        msg.To.Add(new System.Net.Mail.MailAddress(To));
                        msg.From = new System.Net.Mail.MailAddress("Invoice@razi-foundation.com");
                        msg.Subject = string.Format("صورت حساب قرارداد {0}", this.grdContracts.CurrentRow.Cells["ContractNo"].Value.ToString());
                        msg.Body = String.Format("<p dir={0}>مشتری گرامی <br />با سلام؛<br /> احتراما خدمات درخواستی آن شرکت محترم؛ طی نامه شماره    {1}  مورخ      {2} ، قرارداد پذیرش شده در این بنیاد با شماره پیگیری {3}، انجام پذیرفته و گزارش نتایج آزمون آماده تحویل می باشد. همچنین صورت حساب خدمات آزمایشگاهی ارائه شده به پیوست ارسال می گردد.</p>", "rtl", this.grdContracts.CurrentRow.Cells["LetterNo"].Value.ToString(), this.grdContracts.CurrentRow.Cells["LetterDate"].Value.ToString(), this.grdContracts.CurrentRow.Cells["ContractNo"].Value.ToString());
                        msg.Attachments.Add(new System.Net.Mail.Attachment(Bills.MakeBill(), string.Format("صورت حساب قرارداد {0}.pdf", this.grdContracts.CurrentRow.Cells["ContractNo"].Value.ToString())));
                        msg.IsBodyHtml = true;
                        SendSMS.Classes.Utility.Send(msg);
                        MessageBox.Show("صورت حساب با موفقیت ارسال شد");
                    }
                }
                
                List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            }
        }


        private void grdBill_CurrentCellChanged(object sender, EventArgs e)
        {
            this.billReissuesList1.UpdateRow();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (this.grdContracts.SelectedItems.Count > 0)
            {
                RASF.General.Data.Contracts_Base_Edit CurrentRow = (RASF.General.Data.Contracts_Base_Edit)this.grdContracts.SelectedItems[0].GetRow().DataRow;
                CurrentRow.RowState = General.Enums.RowState.Updated;
                this.contractsReissuesList1.Update();
            }

            this.contractsReissuesList1.Fill();
            this.grdContracts.Refetch();
        }
    }
}

