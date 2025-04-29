using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.Messaging.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            RASF.Messaging.Server.Classes.Server_Connection Server = new RASF.Messaging.Server.Classes.Server_Connection();
            Server.Intial();
            Console.WriteLine("Server Begin Listening");
            Console.WriteLine("Press Any Key to Exit");
            Console.ReadKey();
        }
    }
}
