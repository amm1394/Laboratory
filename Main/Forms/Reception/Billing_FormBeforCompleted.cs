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
    public partial class Billing_FormBeforCompleted : RASF.General.Forms.Base.DockContentForm
    {
        private Guid ContractsCode = Guid.Empty;
        private string To;
       public Billing_FormBeforCompleted()
        {
            InitializeComponent();
            ShowpnlUpdate = true;
            this.contractsBillingList1.spName = "Contracts_Billing_BeforIsCompleted";
       
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

                List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
                
                this.contractsBillingList1.Fill(Parameters);
                this.grdContract.Refetch();

                if (this.grdContract.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record)
                //if (this.contractsBillingList1.Count() > 0)
                {
                    this.grdContract.SelectedItems.Clear();
                    this.grdContract.SelectedItems.Add(0);
                }

                //ایمیل صورت حساب
                SendSMS.Classes.SurvayBillForEmailBillList SurvayBillInfo = new SendSMS.Classes.SurvayBillForEmailBillList();
                SurvayBillInfo.Fill(RASF.General.Classes.Global.FinancialYear, Convert.ToInt32((int)this.grdContract.CurrentRow.Cells["ContractNo"].Value));

                SendSMS.Classes.Bills Bills = new SendSMS.Classes.Bills();
                Bills.ContractNo = Convert.ToInt32((int)this.grdContract.CurrentRow.Cells["ContractNo"].Value);
                Bills.FinancialYear = RASF.General.Classes.Global.FinancialYear;
                Bills.MakeBill();

                //Bills.ContractNo = Convert.ToInt32((int)this.grdContract.CurrentRow.Cells["ContractNo"].Value);
                //Bills.FinancialYear = RASF.General.Classes.Global.FinancialYear;

                List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", ContractsCode));
                To = RASF.General.Lists.SendEmailList.FillScalar("SendEmail_Select", Parameter2).ToString();

                if (SurvayBillInfo.list[0].Check == 0)
                {
                    using (System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage())
                    {
                        msg.To.Add(new System.Net.Mail.MailAddress(To));
                        msg.From = new System.Net.Mail.MailAddress("Invoice@razi-foundation.com");
                        msg.Subject = "bill From Razi Applied Science Foundation";
                        msg.Body = "<h3>Please see the attachment</h3>";
                        msg.Attachments.Add(new System.Net.Mail.Attachment(Bills.MakeBill(), "صورت حساب.pdf"));
                        msg.IsBodyHtml = true;
                        SendSMS.Classes.Utility.Send(msg);
                        MessageBox.Show("صورت حساب با موفقیت ارسال شد");
                    }
                }

            }
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

        //private void btnExit_Click(object sender, EventArgs e)
        //{

        //}
    }
}
