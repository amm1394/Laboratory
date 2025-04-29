using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class CashList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Cash>
    {
        public CashList()
        {
            this.spName = "Cash";
            this.list = new List<RASF.General.Data.Cash>();
            this.deletedlist = new List<RASF.General.Data.Cash>();
        }

        public CashList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
       
    }
}
