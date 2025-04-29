using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class PartsMasterSendEmailOutoList : RASF.General.Lists.Base.BaseList<RASF.General.Data.PartsMasterPrintReport>
    {
        public PartsMasterSendEmailOutoList()
        {
            this.spName = "PartsMasterSendEmail";
            this.list = new List<RASF.General.Data.PartsMasterPrintReport>();
            this.deletedlist = new List<RASF.General.Data.PartsMasterPrintReport>();
        }

        public PartsMasterSendEmailOutoList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
     
    }
    
}
