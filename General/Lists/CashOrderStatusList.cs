using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CashOrderStatusList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CashOrderStatus>
    {
        public CashOrderStatusList()
        {
            this.spName = "CashOrderStatus";
            this.list = new List<RASF.General.Data.CashOrderStatus>();
            this.deletedlist = new List<RASF.General.Data.CashOrderStatus>();
        }

        public CashOrderStatusList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
