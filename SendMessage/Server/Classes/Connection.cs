using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.Messaging.Server.Classes
{
    public class Server_Connection : RASF.Messaging.General.Classes.Connection
    {
        private List<RASF.Messaging.General.Classes.Client> Clients { get; set; }
        public void Intial()
        {

            this.Clients = new List<RASF.Messaging.General.Classes.Client>();
            this.IPAddress = System.Net.IPAddress.Parse("127.0.0.1");
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
            this.Socket.Bind(new System.Net.IPEndPoint(this.IPAddress, this.Port));
            this.Socket.Listen(1000);

            while (true)
            {
                System.Net.Sockets.Socket ClientSocket = this.Socket.Accept();

                if (ClientSocket != null)
                {
                    General.Classes.Client Client = new General.Classes.Client(ClientSocket);
                    Client.RecivedMessage += Client_RecivedMessage;
                    Client.Logout += Client_Logout;
                    this.Clients.Add(Client);
                }
            }
        }

        private void Client_Logout(object sender, EventArgs e)
        {
            this.Clients.Remove((General.Classes.Client)sender);
        }

        private void Client_RecivedMessage(General.Events.RecivedEventArgs e)
        {
            foreach (General.Classes.Client Client in Clients.Where(cl => cl.UserId == e.Packet.Reciver))
            {
                Client.SendMessage(e.Packet);
            }
        }
    }
}
