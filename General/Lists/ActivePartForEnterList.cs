using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ActivePartForEnterList : RASF.General.Lists.Base.BaseList<RASF.General.Data.PartsMasterPrintReport>
    {
        public ActivePartForEnterList()
        {
            this.spName = "ActivePartForEnter";
            this.list = new List<RASF.General.Data.PartsMasterPrintReport>();
            this.deletedlist = new List<RASF.General.Data.PartsMasterPrintReport>();
        }

        public ActivePartForEnterList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
