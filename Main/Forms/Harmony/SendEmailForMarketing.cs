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
    public partial class SendEmailForMarketing : RASF.General.Forms.Base.DockContentForm
    {
        public SendEmailForMarketing()
        {
            InitializeComponent();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrWhiteSpace(this.txtSearch.Text) == false)
            //{
            //    List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            //    Parameter.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
            //    Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractNo", this.txtSearch.Text));
            //    this.sendEmailOfBillsList1.Fill(Parameter);
            //    this.grdBills.Refetch();

            //    this.txtEmail.Text = this.sendEmailOfBillsList1[0].Email;
                         
            //}
        }

        public void DoWork()
        {
            SendSMS.EmailMarketingList EmailMarketing = new SendSMS.EmailMarketingList();
            EmailMarketing.Fill();

            SendSMS.Classes.Marketing Marketing = new SendSMS.Classes.Marketing();
            //Bills.ContractNo = Convert.ToInt32(this.txtSearch.Text);
            //Bills.FinancialYear = RASF.General.Classes.Global.FinancialYear;
            //Marketing.MakeBill(i);

            //Bills.ContractNo = Convert.ToInt32(this.txtSearch.Text);
            //Bills.FinancialYear = RASF.General.Classes.Global.FinancialYear;

            //  if (SurvayBillInfo.list[0].Check == 0)
            //  {
            for (int i = 0; i < EmailMarketing.list.Count(); i++)
            {
                txtEmail.Text = EmailMarketing.list[i].EmailAdd;
                using (System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage())
                {
                    msg.To.Add(new System.Net.Mail.MailAddress(this.txtEmail.Text));
                    msg.From = new System.Net.Mail.MailAddress("marketing@razi-foundation.com");
                    msg.Subject = "دعوتنامه نمایشگاه بین المللی نفت و گاز و پتروشیمی";
                    msg.Body = "<h3>لطفا فایل ضمیمه را مطالعه فرمایید</h3>";
                    msg.Attachments.Add(new System.Net.Mail.Attachment("D:\\Users\\knabavi\\Source\\Workspaces\\Laboratory\\General\\Resources\\نمایشگاه 4.pdf"));
                    msg.IsBodyHtml = true;
                    SendSMS.Classes.Utility.Send(msg);
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            DoWork();
        }
    }
}