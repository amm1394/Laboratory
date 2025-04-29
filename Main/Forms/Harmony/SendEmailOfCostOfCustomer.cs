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
    public partial class SendEmailOfCostOfCustomer : RASF.General.Forms.Base.DockContentForm
    {
        public SendEmailOfCostOfCustomer()
        {
            InitializeComponent();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtSearch.Text) == false)
            {

                //List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                //Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractNo", this.txtSearch.Text));
                //this.findContractNoList1.Fill(Parameter);

                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractNo", this.txtSearch.Text));
                this.sendEmailOfCostOfCustomerList1.Fill(Parameter);
                this.grdCostomerCost.Refetch();

                this.txtEmail.Text = this.sendEmailOfCostOfCustomerList1[0].Email;
                         
            }
        }

        public void DoWork()
        {

            SendSMS.ContractInfoList ContractInfo = new SendSMS.ContractInfoList();
            ContractInfo.Fill(RASF.General.Classes.Global.FinancialYear, Convert.ToInt32(this.txtSearch.Text));
            
            SendSMS.PartsInfoList PartsInfo = new SendSMS.PartsInfoList();
            PartsInfo.Fill(RASF.General.Classes.Global.FinancialYear, Convert.ToInt32(this.txtSearch.Text));

            SendSMS.TestInfoList TestInfo = new SendSMS.TestInfoList();
            TestInfo.Fill(RASF.General.Classes.Global.FinancialYear, Convert.ToInt32(this.txtSearch.Text));

            SendSMS.Classes.SurvayCostForEmailList SurvayCostInfo = new SendSMS.Classes.SurvayCostForEmailList();
            SurvayCostInfo.Fill(RASF.General.Classes.Global.FinancialYear, Convert.ToInt32(this.txtSearch.Text));

            if (SurvayCostInfo.list[0].Check == 0)
            {
                SendSMS.Classes.MakeCostDetailHtml MakeCostDetailHtml = new SendSMS.Classes.MakeCostDetailHtml();

                using (System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage())
                {
                    msg.To.Add(new System.Net.Mail.MailAddress(this.txtEmail.Text));
                    msg.From = new System.Net.Mail.MailAddress("Reports@razi-foundation.com");
                    msg.Subject = "Razi Applied Science Foundation";
                    msg.Body = MakeCostDetailHtml.MakeHtml(ContractInfo, PartsInfo, TestInfo);
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