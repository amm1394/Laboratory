using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.Messaging.Client.Classes
{
    public class Client_Connection : RASF.Messaging.General.Classes.Connection
    {
        public event RASF.Messaging.General.Events.RecivedMessage RecivedMessage;
        protected System.Net.Sockets.NetworkStream NetworkStream { get; set; }

        public Guid UserId { get; private set; }

        private System.ComponentModel.BackgroundWorker Reciveworker;
        public void Intial(String IpAdress, Guid userId)
        {
            this.UserId = userId;
            this.IPAddress = System.Net.IPAddress.Parse(IpAdress);
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.worker.DoWork += worker_DoWork;
            this.worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            this.worker.RunWorkerAsync();
        }

        private void worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
        }

        private void worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            this.Socket = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);
          //  this.Socket.Connect(this.IPAddress, this.Port);
         //   this.NetworkStream = new System.Net.Sockets.NetworkStream(this.Socket);

            if (this.Socket != null)
            {
                //this.NetworkStream = new System.Net.Sockets.NetworkStream(this.Socket);
                //this.SendMessage(new General.Classes.Packet(Guid.Empty, this.UserId, Guid.Empty, "", General.Enums.DataIdentifier.LogIn));

                //this.Reciveworker = new System.ComponentModel.BackgroundWorker();
                //this.Reciveworker.DoWork += Reciveworker_DoWork;
                //this.Reciveworker.RunWorkerCompleted += Reciveworker_RunWorkerCompleted;
                //this.Reciveworker.RunWorkerAsync();
            }
        }

        private void Reciveworker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
        }

        private void Reciveworker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Byte[] ReciveLen = new Byte[4];
            while (this.Socket.Connected)
            {
                int readBytes = this.Socket.Receive(ReciveLen, System.Net.Sockets.SocketFlags.None);
                if (readBytes > 0)
                {
                    Int32 PacketLenght = BitConverter.ToInt32(ReciveLen, 0);
                    Int32 TotalRecived = 0;
                    Byte[] buffer = new Byte[1024];
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                    {
                        while (TotalRecived < PacketLenght)
                        {
                            readBytes = this.Socket.Receive(buffer, System.Net.Sockets.SocketFlags.None);
                            ms.Write(buffer, 0, readBytes);
                            TotalRecived += readBytes;
                        }
                        RASF.Messaging.General.Classes.Packet packet = new RASF.Messaging.General.Classes.Packet(ms.ToArray());

                        if (this.RecivedMessage != null)
                        {
                            this.RecivedMessage(new General.Events.RecivedEventArgs(packet));
                        }
                    }
                }
            }
        }

        public void SendMessage(RASF.Messaging.General.Classes.Packet Message)
        {
            if ((this.Socket != null) && (this.Socket.Connected == true))
            {
                Byte[] message = Message.Serialize();
                this.NetworkStream.Write(message, 0, message.Length);
            }
        }

        public void LogOut()
        {
            this.SendMessage(new General.Classes.Packet(Guid.Empty, this.UserId, Guid.Empty, "", General.Enums.DataIdentifier.LogOut));
        }
    }
}
