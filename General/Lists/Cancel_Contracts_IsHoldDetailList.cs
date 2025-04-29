using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Cancel_Contracts_IsHoldDetailList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Cancel_Contracts_IsHoldDetail>
    {
        public Cancel_Contracts_IsHoldDetailList()
        {
            this.spName = "Cancel_Contracts_IsHoldDetail";
            this.list = new List<RASF.General.Data.Cancel_Contracts_IsHoldDetail>();
            this.deletedlist = new List<RASF.General.Data.Cancel_Contracts_IsHoldDetail>();
        }

        public Cancel_Contracts_IsHoldDetailList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

