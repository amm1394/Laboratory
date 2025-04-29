using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Cancel_Contracts_IsHoldedList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Cancel_Contracts_IsHold>
    {
        public Cancel_Contracts_IsHoldedList()
        {
            this.spName = "Cancel_Contracts_IsHolded";
            this.list = new List<RASF.General.Data.Cancel_Contracts_IsHold>();
            this.deletedlist = new List<RASF.General.Data.Cancel_Contracts_IsHold>();
        }

        public Cancel_Contracts_IsHoldedList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
