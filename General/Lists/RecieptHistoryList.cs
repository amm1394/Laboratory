using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class RecieptHistoryList : RASF.General.Lists.Base.BaseList<RASF.General.Data.RecieptHistory>
    {
        public RecieptHistoryList()
        {
            this.spName = "RecieptHistory";
            this.list = new List<RASF.General.Data.RecieptHistory>();
            this.deletedlist = new List<RASF.General.Data.RecieptHistory>();
        }

        public RecieptHistoryList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
