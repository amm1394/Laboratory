using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class HoldContractNotCompletedList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Cancel_Contracts_IsHold>
    {
        public HoldContractNotCompletedList()
        {
            this.spName = "HoldContractNotCompleted";
            this.list = new List<RASF.General.Data.Cancel_Contracts_IsHold>();
            this.deletedlist = new List<RASF.General.Data.Cancel_Contracts_IsHold>();
        }

        public HoldContractNotCompletedList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

