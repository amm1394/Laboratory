using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS.Classes
{
   public class Cost : InterFace.MessageInterFace
    {
       public int FinancialYear { get; set; }

       public int ContractNo { get; set; }

        public Message Message  { get ; set; }

        private Int64 CalCost { get; set; }

        private string Email { get; set; }

        public void DoWork()
        {
            SurvayCostForEmailList SurvayCostInfo = new SurvayCostForEmailList();
            SurvayCostInfo.Fill(FinancialYear, ContractNo);

            if (SurvayCostInfo.list[0].Check == 0)
            {
                using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection("Data Source=192.168.0.3;Initial Catalog=LaboratoryRASF;Persist Security Info=True;User ID=sa;Password=AliReza23280"))
                {
                    using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("CalculateCost_Select", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;
                        Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractNo", ContractNo));
                        Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", FinancialYear));
                        Connection.Open();
                        CalCost = Convert.ToInt64(Command.ExecuteScalar());
                        Connection.Close();
                    }
                }
                Message.Result = String.Format("مبلغ پیش بینی شده مربوط به شماره پیگیری {0} متعلق به سال {2}،{1} ریال می باشد", ContractNo, FinancialYear, CalCost);
            }
            else
            {
                if ((SurvayCostInfo.list[0].Check & 1) == 1)
                {
                    Message.Result = String.Format("از ارسال مبلغ قرارداد به شماره پیگیری {0} متعلق به سال{1}به ایمیل {2} معذوریم این قرارداد ابطال گردیده است", ContractNo, FinancialYear, Email);
                }
            }
        }
    }
}
