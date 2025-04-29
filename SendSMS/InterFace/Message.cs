using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS
{
    public class Message
    {
        public Int32 Id { get; set; }
        private String Request { get; set; }
        public String Result { get; set; }
        public String From { get; set; }
        private DateTime Date { get; set; }
        public String SendId { get;  set; }

        private SendSMS.InterFace.MessageInterFace SndSms;

        public Message(Int32 id, String request, String from)
        {
            this.Id = id;
            this.Request = request;
            this.From = from;
            this.Date = System.DateTime.Now;
        }
        public void Parse()
        {
            if (Request.StartsWith("*"))
            {
                String[] Mess = Request.Split('*');
                try
                {
                    int Requset = Convert.ToInt32(Mess[1]);
                    int ContractNo = Convert.ToInt32(Mess[2]);
                    int FinancialYear = Convert.ToInt32(Mess[3]);
                    Boolean ExistContract = false;
                    using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection("Data Source=192.168.0.3;Initial Catalog=LaboratoryRASF;Persist Security Info=True;User ID=sa;Password=AliReza23280"))
                    {
                        using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("ExistContract_Select", Connection))
                        {
                            Command.CommandType = System.Data.CommandType.StoredProcedure;
                            Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractNo", ContractNo));
                            Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", FinancialYear));
                            Connection.Open();
                            ExistContract = Convert.ToBoolean(Command.ExecuteScalar());
                            Connection.Close();
                        }
                    }
                    if (ExistContract == true)
                    {
                        switch (Requset)
                        {
                            case 1:
                                {
                                    SndSms = new SendSMS.Classes.SendOfStatus();
                                    SndSms.ContractNo = ContractNo;
                                    SndSms.FinancialYear = FinancialYear;
                                }
                                break;
                            case 2:
                                {
                                    SndSms = new SendSMS.Classes.Cost();
                                    SndSms.ContractNo = ContractNo;
                                    SndSms.FinancialYear = FinancialYear;
                                }
                                break;
                            case 3:
                                {
                                    SndSms = new SendSMS.Classes.EmailOfCast();
                                    SndSms.ContractNo = ContractNo;
                                    SndSms.FinancialYear = FinancialYear;
                                }
                                break;
                            case 4:
                                {
                                    SndSms = new SendSMS.Classes.EmailOfCostDetail();
                                    SndSms.ContractNo = ContractNo;
                                    SndSms.FinancialYear = FinancialYear;
                                }
                                break;
                            case 5:
                                {
                                    SndSms = new SendSMS.Classes.Bills();
                                    SndSms.ContractNo = ContractNo;
                                    SndSms.FinancialYear = FinancialYear;
                                }
                                break;
                            case 6:
                                {
                                    SndSms = new SendSMS.Classes.SendReports();
                                    SndSms.ContractNo = ContractNo;
                                    SndSms.FinancialYear = FinancialYear;
                                }
                                break;
                        }
                    }
                    else
                    {
                        SndSms = new SendSMS.Classes.InvalidMessage();
                        SndSms.ContractNo = ContractNo;
                        SndSms.FinancialYear = FinancialYear;
                    }
                }
                catch
                {
                    SndSms = new SendSMS.Classes.InvalidMessage();
                }
            }
            else
            {
                SndSms = new SendSMS.Classes.InvalidMessage();
            }
            SndSms.Message = this;
            SndSms.DoWork();
        }

        public void SendResult()
        {
            System.ServiceModel.BasicHttpBinding binding = new System.ServiceModel.BasicHttpBinding(System.ServiceModel.BasicHttpSecurityMode.None);
            System.ServiceModel.EndpointAddress remoteAddress = new System.ServiceModel.EndpointAddress("http://www.afe.ir/WebService/V5/BoxService.asmx");
            SendSms_V5.BoxServiceSoapClient client = new SendSms_V5.BoxServiceSoapClient(binding, remoteAddress);
            SendSms_V5.ArrayOfString mobile = new SendSms_V5.ArrayOfString {this.From };
            this.SendId = client.SendMessage("amazaheri@razi-foundation.com", "858977", "30007957954535", mobile, this.Result, "1")[0];
        }

        public void UpdateLogs()
        {
            using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection("Data Source=192.168.0.3;Initial Catalog=LaboratoryRASF;Persist Security Info=True;User ID=sa;Password=AliReza23280"))
            {
                using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("SendSMSLog_Update", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("Id", Id));
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("SendID", SendId));

                    Connection.Open();
                    Command.ExecuteNonQuery();
                    Connection.Close();
                }
            }
        }

        public void InsertLogs()
        {
            using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection("Data Source=192.168.0.3;Initial Catalog=LaboratoryRASF;Persist Security Info=True;User ID=sa;Password=AliReza23280"))
            {
                using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("GetSMSLastID_Insert", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("Id", Id));
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("Request", Request));
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("Result", Result));
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("From", From));
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("Date", Date));
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("SendId", SendId));

                    Connection.Open();
                    Command.ExecuteNonQuery();
                    Connection.Close();
                }
            }
        }
    }
}
