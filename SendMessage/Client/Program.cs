using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //RASF.Messaging.Client.Classes.Client_Connection Client = new RASF.Messaging.Client.Classes.Client_Connection();
            //Client.Intial();
            //Console.WriteLine("Client Is Connected To Server");
            //Console.WriteLine("Enter Yor Message");
            //String Message = Console.ReadLine();
            //while (String.IsNullOrWhiteSpace(Message) == false)
            //{
            //    Client.SendMessage(new RASF.Messaging.General.Classes.Packet(Client.UserId, Guid.Empty, Message, RASF.Messaging.General.Enums.DataIdentifier.Message));
            //    Message = Console.ReadLine();
            //}
            //Client.SendMessage(new RASF.Messaging.General.Classes.Packet(Guid.Empty, Guid.Empty, Message, RASF.Messaging.General.Enums.DataIdentifier.LogOut));
        }
    }
}
