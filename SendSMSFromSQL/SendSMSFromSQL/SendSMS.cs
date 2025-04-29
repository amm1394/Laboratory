using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMSFromSQL
{
    public class SendSMS
    {
        private String SendId { get; set; }
       
        SendSMSFromSQL.Class.ReturnNotSendSMS ReturnNotSendSMS = new SendSMSFromSQL.Class.ReturnNotSendSMS();
      
        public void DoWork()
        {
           SendSMSFromSQL.Class.ReturnNotSendSMS ReturnNotSendSMS = new SendSMSFromSQL.Class.ReturnNotSendSMS();
           ReturnNotSendSMS.Fill();


     
        }
        public void UpdateSendSmsLog()
        {
            using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection("Data Source=sql-1;Initial Catalog=LaboratoryRASF;Persist Security Info=True;User ID=sa;Password=AliReza23280"))
            {
                using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("SendSMSLog_Update", Connection))
                {
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("SendId", SendId));
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SendSMSLogID", ReturnNotSendSMS.ReturnNoSendSMSList[0].SendSMSLogID));

                    Connection.Open();
                    Command.ExecuteNonQuery();
                    Connection.Close();
                }
            }
        }



    }

   
      //public void SendResult()
      //  {
      //      //System.ServiceModel.BasicHttpBinding binding = new System.ServiceModel.BasicHttpBinding(System.ServiceModel.BasicHttpSecurityMode.None);
      //      //System.ServiceModel.EndpointAddress remoteAddress = new System.ServiceModel.EndpointAddress("http://www.afe.ir/WebService/V5/BoxService.asmx");
      //      //SendSms_V5.BoxServiceSoapClient client = new SendSms_V5.BoxServiceSoapClient(binding, remoteAddress);
      //      //SendSms_V5.ArrayOfString mobile = new SendSms_V5.ArrayOfString {
      //      //this.From
      //  //};
      //    //  this.SendId = client.SendMessage("amazaheri@razi-foundation.com", "858977", "30007957954535", mobile, this.Result, "1")[0];
      //  }
}

