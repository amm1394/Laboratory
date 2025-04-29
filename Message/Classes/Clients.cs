using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.Messaging.General.Classes
{
    public class Client
    {
        public event RASF.Messaging.General.Events.RecivedMessage RecivedMessage;

        public event System.EventHandler Logout;
        public Guid UserId { get; private set; }
        public System.Net.Sockets.Socket Socket { get; private set; }
        public System.Net.Sockets.NetworkStream NetworkStream { get; private set; }

        private System.ComponentModel.BackgroundWorker Reciveworker;

        public Client(System.Net.Sockets.Socket socket)
        {
            this.Socket = socket;

            this.NetworkStream = new System.Net.Sockets.NetworkStream(this.Socket);
            this.Reciveworker = new System.ComponentModel.BackgroundWorker();
            this.Reciveworker.DoWork += Reciveworker_DoWork;
            this.Reciveworker.RunWorkerCompleted += Reciveworker_RunWorkerCompleted;
            this.Reciveworker.RunWorkerAsync();
        }

        public void SendMessage(Packet Message)
        {
            if ((this.Socket != null) && (this.Socket.Connected == true))
            {
                try
                {
                    Byte[] message = Message.Serialize();
                    this.NetworkStream.Write(message, 0, message.Length);
                }
                catch
                {
                    this.Socket.Disconnect(true);
                    if (this.Logout != null)
                    {
                        this.Logout(this, new EventArgs());
                    }
                }
            }
            else
            {
                this.Socket.Disconnect(true);
                if (this.Logout != null)
                {
                    this.Logout(this, new EventArgs());
                }
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
                try
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
                            Packet packet = new Packet(ms.ToArray());
                            switch (packet.DataIdentifier)
                            {
                                case Enums.DataIdentifier.LogIn:
                                    {
                                        this.UserId = packet.Sender;
                                    }
                                    break;
                                case Enums.DataIdentifier.LogOut:
                                    {
                                        this.Socket.Disconnect(true);
                                        if (this.Logout != null)
                                        {
                                            this.Logout(this, new EventArgs());
                                        }
                                    }
                                    break;
                                case Enums.DataIdentifier.None:
                                    {

                                    }
                                    break;
                                case Enums.DataIdentifier.Message:
                                    {
                                        if (this.RecivedMessage != null)
                                        {
                                            this.RecivedMessage(new Events.RecivedEventArgs(packet));
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                }
                catch
                {
                    this.Socket.Disconnect(true);
                    if (this.Logout != null)
                    {
                        this.Logout(this, new EventArgs());
                    }
                }
            }
        }
    }
}