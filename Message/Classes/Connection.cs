using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.Messaging.General.Classes
{
    public class Connection
    {
        protected System.Net.Sockets.Socket Socket { get; set; }
        protected System.Net.IPAddress IPAddress { get; set; }
        protected Int16 Port { get; set; }

        protected System.ComponentModel.BackgroundWorker worker;
        public Connection()
        {
            this.Port = 9000;
        }
    }
}
