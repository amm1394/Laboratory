using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class HoldedBeforeFinancialList : RASF.General.Lists.Base.BaseList<RASF.General.Data.HoldedBeforeFinancial>
    {
        public HoldedBeforeFinancialList()
        {
            this.spName = "HoldedBeforeFinancial";
            this.list = new List<RASF.General.Data.HoldedBeforeFinancial>();
            this.deletedlist = new List<RASF.General.Data.HoldedBeforeFinancial>();
        }

        public HoldedBeforeFinancialList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
