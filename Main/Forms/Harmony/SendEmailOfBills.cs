using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace RASF.Main.Forms.Harmony
{
    public partial class SendEmailOfBills : RASF.General.Forms.Base.DockContentForm
    {
        public SendEmailOfBills()
        {
            InitializeComponent();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtSearch.Text) == false)
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractNo", this.txtSearch.Text));
                this.sendEmailOfBillsList1.Fill(Parameter);
                this.grdBills.Refetch();

                this.txtEmail.Text = this.sendEmailOfBillsList1[0].Email;
                         
            }
        }

        public void DoWork()
        {
            SendSMS.Classes.SurvayBillForEmailBillList SurvayBillInfo = new SendSMS.Classes.SurvayBillForEmailBillList();
            SurvayBillInfo.Fill(RASF.General.Classes.Global.FinancialYear,Convert.ToInt32(this.txtSearch.Text));

            SendSMS.Classes.Bills Bills = new SendSMS.Classes.Bills();
            Bills.ContractNo = Convert.ToInt32(this.txtSearch.Text);
            Bills.FinancialYear = RASF.General.Classes.Global.FinancialYear;
            Bills.MakeBill();

            Bills.ContractNo = Convert.ToInt32(this.txtSearch.Text);
            Bills.FinancialYear = RASF.General.Classes.Global.FinancialYear;

            if (SurvayBillInfo.list[0].Check == 0)
            {
                using (System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage())
                {
                    msg.To.Add(new System.Net.Mail.MailAddress(this.txtEmail.Text));
                    msg.From = new System.Net.Mail.MailAddress("Invoice@razi-foundation.com");
                    msg.Subject = string.Format("صورت حساب قرارداد {0}", (this.txtSearch.Text));
                    msg.Body = String.Format("<p dir={0}>مشتری گرامی <br />با سلام؛<br /> احتراما خدمات درخواستی آن شرکت محترم؛ طی نامه شماره    {1}  مورخ      {2} ، قرارداد پذیرش شده در این بنیاد با شماره پیگیری {3}، انجام پذیرفته و گزارش نتایج آزمون آماده تحویل می باشد. همچنین صورت حساب خدمات آزمایشگاهی ارائه شده به پیوست ارسال می گردد.</p>", "rtl", this.sendEmailOfBillsList1[0].LetterNo, this.sendEmailOfBillsList1[0].LetterDate, this.txtSearch.Text);
                    msg.Attachments.Add(new System.Net.Mail.Attachment(Bills.MakeBill(), string.Format("صورت حساب قرارداد {0}.pdf", this.txtSearch.Text)));
                    msg.IsBodyHtml = true;
                    SendSMS.Classes.Utility.Send(msg);
                }
                MessageBox.Show("صورت حساب با موفقیت ارسال شد");
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            DoWork();
        }
    }
}