using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS.Classes
{
   public class ReturnNotSendSMS
    {

       public List<Message> SendSMSList = new List<Message>();
       public void Fill()
       {
           using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection("Data Source=192.168.0.3;Initial Catalog=LaboratoryRASF;Persist Security Info=True;User ID=sa;Password=AliReza23280"))
           {
               using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("SendSMSLog_Select", Connection))
               {
                   Command.CommandType = System.Data.CommandType.StoredProcedure;
                   Connection.Open();
                   System.Data.SqlClient.SqlDataReader dr = Command.ExecuteReader();
                   while (dr.Read())
                   {
                       Message SMS = new Message(Convert.ToInt32(dr.GetValue(0)), "", dr.GetValue(1).ToString());
                       SMS.Result = dr.GetValue(2).ToString();

                       SendSMSList.Add(SMS);
                   }
                   Connection.Close();
               }
           }
       }
    }
}
