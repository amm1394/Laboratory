using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS.Classes
{
    public class CheckSms
    {
        public CheckSms()
        {
        }

        public void SendOutBox()
        {
            ReturnNotSendSMS  ReturnNotSendSMSList= new ReturnNotSendSMS();
            ReturnNotSendSMSList.Fill();

            foreach (Message message in ReturnNotSendSMSList.SendSMSList)
            {
                message.SendResult();
                message.UpdateLogs();
            }
        }
        public void CheckInBox()
        {
            GetSms.MessageReceived[] messegaReceived = new GetSms.MessageReceived[0];
            try
            {
                System.ServiceModel.BasicHttpBinding binding = new System.ServiceModel.BasicHttpBinding(System.ServiceModel.BasicHttpSecurityMode.None);
                System.ServiceModel.EndpointAddress epa = new System.ServiceModel.EndpointAddress("http://www.afe.ir/WebService/Inboxservice.asmx");
                GetSms.InboxServiceSoapClient InboxService = new GetSms.InboxServiceSoapClient(binding, epa);

                messegaReceived = InboxService.List("amazaheri@razi-foundation.com", "858977", "30007957954535", GetLastId(), 100);
            }
            catch
            {
            }
            foreach (GetSms.MessageReceived message in messegaReceived)
            {
                Message LastMessage = new Message(message.ID, message.Body, message.From);
                LastMessage.Parse();
                LastMessage.SendResult();
                LastMessage.InsertLogs();
            }
        }

        private int GetLastId()
        {
            int LastId;
            using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection("Data Source=192.168.0.3;Initial Catalog=LaboratoryRASF;Persist Security Info=True;User ID=sa;Password=AliReza23280"))
            {
                using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("GetSMSLastID_Select", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    LastId = Convert.ToInt32(Command.ExecuteScalar());
                    Connection.Close();
                }
            }
            return LastId;
        }
    }
}
