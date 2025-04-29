using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.Messaging.General.Events
{
    public class RecivedEventArgs : EventArgs
    {
        public readonly RASF.Messaging.General.Classes.Packet Packet;

        public RecivedEventArgs(RASF.Messaging.General.Classes.Packet packet)
        {
            this.Packet = packet;
        }
    }

    public delegate void RecivedMessage(RecivedEventArgs e);
}
