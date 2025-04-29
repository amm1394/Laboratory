using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CancelFinacialSupportList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Contracts_IsHold>
    {
        public CancelFinacialSupportList()
        {
            this.spName = "CancelFinacialSupport";
            this.list = new List<RASF.General.Data.Contracts_IsHold>();
            this.deletedlist = new List<RASF.General.Data.Contracts_IsHold>();
        }

        public CancelFinacialSupportList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

