using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.Messaging.General.Classes
{
    [Serializable()]
    public class Packet
    {
        public RASF.Messaging.General.Enums.DataIdentifier DataIdentifier;
        public Guid Id { get; set; }
        public Guid Sender { get; set; }
        public Guid Reciver { get; set; }
        public string Message { get; set; }

        public Packet(Guid id, Guid sender, Guid reciver, String message, RASF.Messaging.General.Enums.DataIdentifier dataIdentifier)
        {
            this.Id = id;
            this.Sender = sender;
            this.Reciver = reciver;
            this.Message = message;
            this.DataIdentifier = dataIdentifier;
        }

        public Packet(Byte[] message)
        {
            using (System.IO.MemoryStream objectStrem = new System.IO.MemoryStream(message))
            {
                using (C1.C1Zip.C1ZStreamReader decompressor = new C1.C1Zip.C1ZStreamReader(objectStrem))
                {
                    System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    RASF.Messaging.General.Classes.Packet deserializePacket = (RASF.Messaging.General.Classes.Packet)formatter.Deserialize(decompressor);

                    this.Id = deserializePacket.Id;
                    this.Sender = deserializePacket.Sender;
                    this.Reciver = deserializePacket.Reciver;
                    this.Message = deserializePacket.Message;
                    this.DataIdentifier = deserializePacket.DataIdentifier;
                }
            }
        }

        public Byte[] Serialize()
        {
            using (System.IO.MemoryStream objectStrem = new System.IO.MemoryStream())
            {
                using (C1.C1Zip.C1ZStreamWriter compressor = new C1.C1Zip.C1ZStreamWriter(objectStrem))
                {
                    System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    formatter.Serialize(compressor, this);
                    Byte[] buffer = new Byte[objectStrem.Length + 4];
                    System.Buffer.BlockCopy(BitConverter.GetBytes(objectStrem.Length), 0, buffer, 0, 4);
                    System.Buffer.BlockCopy(objectStrem.ToArray(), 0, buffer, 4, (int)objectStrem.Length);
                    return buffer;
                }
            }
        }
    }
}