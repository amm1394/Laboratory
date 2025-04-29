using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS.Classes
{
    public class PartsMasterSendEmailWithSMS : RASF.General.Lists.PartsMasterSendEmailList
    {
        public PartsMasterSendEmailWithSMS()
        {
            this.spName = "PartsMasterSendEmail";
            this.list = new List<RASF.General.Data.PartsMasterPrintReport>();
            this.deletedlist = new List<RASF.General.Data.PartsMasterPrintReport>();
        }
    }
}
