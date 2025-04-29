using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS.Classes
{
    public class EmailOfCostDetail : InterFace.MessageInterFace
    {
        public int FinancialYear { get; set;}

        public int ContractNo { get; set; }


        public Message Message { get; set; }


        public void DoWork()
        {

            ContractInfoList ContractInfo = new ContractInfoList();
            ContractInfo.Fill(FinancialYear, ContractNo);

            PartsInfoList PartsInfo = new PartsInfoList();
            PartsInfo.Fill(FinancialYear, ContractNo);

            TestInfoList TestInfo = new TestInfoList();
            TestInfo.Fill(FinancialYear, ContractNo);

            SurvayCostForEmailList SurvayCostInfo = new SurvayCostForEmailList();
            SurvayCostInfo.Fill(FinancialYear, ContractNo);

            if (SurvayCostInfo.list[0].Check == 0)
            {
                MakeCostDetailHtml MakeCostDetailHtml = new MakeCostDetailHtml();

                using (System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage())
                {
                    msg.To.Add(new System.Net.Mail.MailAddress(ContractInfo.list[0].Email));
                    msg.From = new System.Net.Mail.MailAddress("Reports@razi-foundation.com");
                    msg.Subject = "Reoprt From Razi Applied Science Foundation";
                    msg.Body = MakeCostDetailHtml.MakeHtml(ContractInfo, PartsInfo, TestInfo);
                    msg.IsBodyHtml = true;
                    SendSMS.Classes.Utility.Send(msg);
                }

                Message.Result = String.Format("برگه اعلام هزینه درخواست به شماره پیگیری {0} متعلق به سال{1}به ایمیل {2}ارسال گردید", ContractNo, FinancialYear, ContractInfo.list[0].Email);
            }
            else
            {
                if ((SurvayCostInfo.list[0].Check & 1) == 1)
                {
                    Message.Result = String.Format("از ارسال برگه اعلام هزینه درخواست به شماره پیگیری {0} متعلق به سال{1}به ایمیل {2} معذوریم این قرارداد ابطال گردیده است", ContractNo, FinancialYear, ContractInfo.list[0].Email);
                }
            }
        }



     
    }
}
