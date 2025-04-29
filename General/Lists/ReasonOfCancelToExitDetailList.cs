using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReasonOfCancelToExitDetailList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Cancel_Contracts_IsHoldDetail>
    {
        public ReasonOfCancelToExitDetailList()
        {
            this.spName = "ReasonOfCancelToExitDetail";
            this.list = new List<RASF.General.Data.Cancel_Contracts_IsHoldDetail>();
            this.deletedlist = new List<RASF.General.Data.Cancel_Contracts_IsHoldDetail>();
        }

        public ReasonOfCancelToExitDetailList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

