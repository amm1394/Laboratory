using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;


namespace Messaging
{
    public partial class Server : ServiceBase
    {
        public Server()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            RASF.Messaging.Server.Classes.Server_Connection Server = new RASF.Messaging.Server.Classes.Server_Connection();
            Server.Intial();
        }

        protected override void OnStop()
        {
        }

        protected override void OnContinue()
        {
        }  
    }
}
