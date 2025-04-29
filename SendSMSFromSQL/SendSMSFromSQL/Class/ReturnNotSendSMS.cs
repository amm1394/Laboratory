using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMSFromSQL.Class
{
   public class ReturnNotSendSMS
    {
       public List<ReturnNotSendSMS> ReturnNoSendSMSList = new List<ReturnNotSendSMS>();

      //  private String SendId { get; set; }
        public int SendSMSLogID { get; set; }
        private string Mobile { get; set; }
        private string Message { get; set; }
        private int ReturnValue { get; set; }
        private DateTime RegistrationDate { get; set; }
        private Guid ContractsCode { get; set; }

       public  ReturnNotSendSMS()
       {
       }


       public void Fill()
       {
           using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection("Data Source=sql-1;Initial Catalog=LaboratoryRASF;Persist Security Info=True;User ID=sa;Password=AliReza23280"))
           {
               using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("SendSMSLog_Select", Connection))
               {
                   Command.CommandType = System.Data.CommandType.StoredProcedure;
                   Connection.Open();
                   System.Data.SqlClient.SqlDataReader dr = Command.ExecuteReader();
                   while (dr.Read())
                   {
                       ReturnNotSendSMS SendSMSList = new ReturnNotSendSMS();
                       SendSMSList.SendSMSLogID = Convert.ToInt32(dr.GetValue(0));
                       SendSMSList.Mobile = (string)dr.GetValue(1);
                       SendSMSList.Message = dr.GetValue(2).ToString();
                       SendSMSList.ReturnValue =(Int32) dr.GetValue(3);
                       SendSMSList.RegistrationDate =(DateTime) dr.GetValue(4);
                       SendSMSList.ContractsCode = (Guid)dr.GetValue(5);

                       ReturnNoSendSMSList.Add(SendSMSList);
                   }
                   Connection.Close();
               }
           }
       }
    }
}
