using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Events
{
    public class ReternListOfPacketEventArgs : EventArgs
    {
        public readonly List<RASF.Messaging.General.Classes.Packet> Packets;

        public ReternListOfPacketEventArgs(List<RASF.Messaging.General.Classes.Packet> packets)
        {
            this.Packets = packets;
        }
    }

    public delegate void ReturnPacket(ReternListOfPacketEventArgs e);
}
