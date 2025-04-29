using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS.Classes
{
    public class SendReports : InterFace.MessageInterFace
    {
        public int FinancialYear { get; set; }

        public int ContractNo { get; set; }


        public Message Message { get; set; }
      

        private static void AddText(Aspose.Pdf.Page page, String Text, Aspose.Pdf.Text.Position Pos)
        {
            Aspose.Pdf.Text.TextFragment textFragment = new Aspose.Pdf.Text.TextFragment(Text);
            textFragment.Position = Pos;
            textFragment.TextState.FontSize = 9;
            textFragment.TextState.Font = Aspose.Pdf.Text.FontRepository.FindFont("B Lotus");
            textFragment.TextState.Font.IsEmbedded = true;
            textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            Aspose.Pdf.Text.TextBuilder textBuilder = new Aspose.Pdf.Text.TextBuilder(page);
            textBuilder.AppendText(textFragment);
        }

        public void DoWork()
        {
            SurvayDebtorCustomerForEmailReportsList SurvayDebtorInfo = new SurvayDebtorCustomerForEmailReportsList();
            SurvayDebtorInfo.Fill(FinancialYear, ContractNo);

            if (SurvayDebtorInfo.list[0].Check == 0)
            {

                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractNo", ContractNo));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractYear", FinancialYear));

                Object ContractsCode = RASF.General.Lists.CreateContractNumberList.FillScalar("FindContractsCode_Select", Parameter);

                List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", ContractsCode));
                RASF.General.Lists.PartsMasterSendEmailList partsMasterSendEmailList = new RASF.General.Lists.PartsMasterSendEmailList();
                partsMasterSendEmailList.Fill(Parameter1);


                RASF.General.Classes.SendEmail sendEmail = new RASF.General.Classes.SendEmail();
                sendEmail.MakeEmail(partsMasterSendEmailList.list, SurvayDebtorInfo.list[0].Email, Convert.ToInt16(ContractNo));

                Message.Result = String.Format("گزارش درخواست به شماره پیگیری {0} متعلق به سال{1}به ایمیل {2}ارسال گردید", ContractNo, FinancialYear, SurvayDebtorInfo.list[0].Email);
            }
            else
            {
                if ((SurvayDebtorInfo.list[0].Check & 1) == 1)
                {
                    Message.Result = String.Format("از ارسال گزارش درخواست به شماره پیگیری {0} متعلق به سال{1}به ایمیل {2}معذوریم این قرارداد ابطال گردیده است", ContractNo, FinancialYear, SurvayDebtorInfo.list[0].Email);
                }
                else
                {
                    if ((SurvayDebtorInfo.list[0].Check & 2) == 2)
                    {
                        Message.Result = String.Format("از ارسال گزارش درخواست به شماره پیگیری {0} متعلق به سال{1}به ایمیل {2} معذوریم گزارش کامل نمی باشد ", ContractNo, FinancialYear, SurvayDebtorInfo.list[0].Email);
                    }
                    else
                    {
                        Message.Result = String.Format("از ارسال گزارش درخواست به شماره پیگیری {0} متعلق به سال{1}به ایمیل {2} به علت مسائل مالی معذوریم در اسرع وفت با شما تماس گرفته خواهد شد ", ContractNo, FinancialYear, SurvayDebtorInfo.list[0].Email);
                    }
                }
            }
        }
    }
}
