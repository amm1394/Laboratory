using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SendSMS.Classes
{
    public  class SendOfStatus :InterFace.MessageInterFace
    {
        public int FinancialYear { get; set; }
        public int ContractNo { get; set; }
        public Message Message { get; set; }
        public void DoWork()
        {
            using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection("Data Source=192.168.0.3;Initial Catalog=LaboratoryRASF;Persist Security Info=True;User ID=sa;Password=AliReza23280"))
            {
                using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("SendOfStatus_Select", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractNo", ContractNo));
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", FinancialYear));
                    Connection.Open();
                    Message.Result = Command.ExecuteScalar().ToString();
                    Connection.Close();
                }
            }
            Message.Result = String.Format("درخواست به شماره پیگیری {0} متعلق به سال {1} {2}", ContractNo, FinancialYear, Message.Result);
        }
    }
}
