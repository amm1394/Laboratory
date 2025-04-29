using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Message
{
    public partial class SendMessage : RASF.General.Forms.Base.DockContentForm
    {
        public event RASF.General.Events.ReturnPacket ReturnPacket;
        private Guid ContratcCode;
        public SendMessage()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
        }

        public SendMessage(Guid ContractsCode, int ContractNo)
            :this()
        {
            this.searchContract1.ContractNo = ContractNo;
            this.searchContract1_ReturnContractsCode(new General.Events.ReturnContractsCodeEventArgs(ContractsCode));
        }
        private void SendMessage_Load(object sender, EventArgs e)
        {
            if (txtMessage.Text == " ")
            {
                grpMessage.Enabled = false;
                grpMessagePast.Enabled = false;
                grpReceiver.Enabled = false;
            }
            else
            {
                grpMessage.Enabled = true;
                grpMessagePast.Enabled = true;
                grpReceiver.Enabled = true;
            }
            this.laboratory_UserList1.Fill();
            this.grdReceiver.Refetch();
            FillSendMessage();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Int32 ReciverCount = this.laboratory_UserList1.Count(row => row.Check == true);
            if (searchContract1.numContractNo.Text == "0")
            {
                System.Windows.Forms.MessageBox.Show("پیام شما ارسال نشد لطفا شماره قرارداد را وارد نمایید");

            }
            else
            {

                if ((ReciverCount > 0) && (String.IsNullOrWhiteSpace(txtMessage.Text) == false))
                {
                    List<RASF.Messaging.General.Classes.Packet> packets = new List<RASF.Messaging.General.Classes.Packet>();
                    foreach (RASF.General.Data.Laboratory_User Recive in this.laboratory_UserList1.Where(row => row.Check == true))
                    {
                        List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                        Parameter.Add(new System.Data.SqlClient.SqlParameter("Sender", RASF.General.Classes.Global.CurrentUserCode));
                        Parameter.Add(new System.Data.SqlClient.SqlParameter("Receiver", Recive.UserId));
                        Parameter.Add(new System.Data.SqlClient.SqlParameter("Message", txtMessage.Text));
                        Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContratcCode));
                        Guid Id = (Guid)this.sendMessageList1.FillScalar(Parameter);
                        RASF.Messaging.General.Classes.Packet packet = new Messaging.General.Classes.Packet(Id, RASF.General.Classes.Global.CurrentUserCode, Recive.UserId, this.txtMessage.Text, Messaging.General.Enums.DataIdentifier.Message);
                        packets.Add(packet);
                    }
                    if (this.ReturnPacket != null)
                    {
                        this.ReturnPacket(new General.Events.ReternListOfPacketEventArgs(packets));
                    }


                    List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContratcCode));
                    string ConnectorId = (string) (RASF.General.Lists.BanksList.FillScalar("ConnectorOfInvoice", Parameter2));

                    if (ConnectorId != "00000000-0000-0000-0000-000000000000")
                    {
                        List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                        Parameter.Add(new System.Data.SqlClient.SqlParameter("Sender", RASF.General.Classes.Global.CurrentUserCode));
                        Parameter.Add(new System.Data.SqlClient.SqlParameter("Receiver",Guid.Parse(ConnectorId)));
                        Parameter.Add(new System.Data.SqlClient.SqlParameter("Message", txtMessage.Text));
                        Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContratcCode));
                        Guid Id = (Guid)this.sendMessageList1.FillScalar(Parameter);
                        RASF.Messaging.General.Classes.Packet packet = new Messaging.General.Classes.Packet(Id, RASF.General.Classes.Global.CurrentUserCode, Guid.Parse(ConnectorId), this.txtMessage.Text, Messaging.General.Enums.DataIdentifier.Message);
                        packets.Add(packet);
                    }

                    List<System.Data.SqlClient.SqlParameter> Parameter3 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter3.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContratcCode));
                    string ConnectorId2 = (string)RASF.General.Lists.BanksList.FillScalar("ConnectorOfReport", Parameter3);

                    if (ConnectorId2 != "00000000-0000-0000-0000-000000000000" && ConnectorId2 != (ConnectorId))
                    {
                        List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                        Parameter.Add(new System.Data.SqlClient.SqlParameter("Sender", RASF.General.Classes.Global.CurrentUserCode));
                        Parameter.Add(new System.Data.SqlClient.SqlParameter("Receiver",Guid.Parse(ConnectorId2)));
                        Parameter.Add(new System.Data.SqlClient.SqlParameter("Message", txtMessage.Text));
                        Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContratcCode));
                        Guid Id = (Guid)this.sendMessageList1.FillScalar(Parameter);
                        RASF.Messaging.General.Classes.Packet packet = new Messaging.General.Classes.Packet(Id, RASF.General.Classes.Global.CurrentUserCode,Guid.Parse(ConnectorId2), this.txtMessage.Text, Messaging.General.Enums.DataIdentifier.Message);
                        packets.Add(packet);
                    }

                    List<System.Data.SqlClient.SqlParameter> Parameter4= new List<System.Data.SqlClient.SqlParameter>();
                    Parameter4.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContratcCode));
                    int test = (int)RASF.General.Lists.BanksList.FillScalar("TestForThePresence", Parameter4);
                    
                    if(test == 1)
                    {
                        List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                        Parameter.Add(new System.Data.SqlClient.SqlParameter("Sender", RASF.General.Classes.Global.CurrentUserCode));
                        Parameter.Add(new System.Data.SqlClient.SqlParameter("Receiver",new Guid("E35F046A-ADEF-4D84-9632-F12D3191EDFF")));
                        Parameter.Add(new System.Data.SqlClient.SqlParameter("Message", txtMessage.Text));
                        Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContratcCode));
                        Guid Id = (Guid)this.sendMessageList1.FillScalar(Parameter);
                        RASF.Messaging.General.Classes.Packet packet = new Messaging.General.Classes.Packet(Id, RASF.General.Classes.Global.CurrentUserCode,new Guid("E35F046A-ADEF-4D84-9632-F12D3191EDFF"), this.txtMessage.Text, Messaging.General.Enums.DataIdentifier.Message);
                        packets.Add(packet);
                    }
                }

                txtMessage.Text = "";
                searchContract1.numContractNo.Text = "0";
                this.laboratory_UserList1.Fill();
                this.grdReceiver.Refetch();
                FillSendMessage();
                System.Windows.Forms.MessageBox.Show("پیام شما با موفقیت ارسال شد");
            }
        }

        private void searchContract1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {
            
            grpMessage.Enabled = true;
            grpMessagePast.Enabled = true;
            grpReceiver.Enabled = true;

            this.ContratcCode = e.ContractsCode;
            FillSendMessage();

        }

        private void FillSendMessage()
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContratcCode));
            this.sendMessageList1.Fill(Parameter);

            this.grdMessage.Refetch();

            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContratcCode));
            label1.Text =(String) RASF.General.Lists.BanksList.FillScalar("CoNmae_Select",Parameter1);
        }

       

        private void grdMessage_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            txtMessage.Text = this.grdMessage.CurrentRow.Cells["Message"].Value.ToString();
        }
    }
}
