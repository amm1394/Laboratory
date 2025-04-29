using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Contracts_IsHoldList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Contracts_IsHold>
    {
        public Contracts_IsHoldList()
        {
            this.spName = "Contracts_IsHold";
            this.list = new List<RASF.General.Data.Contracts_IsHold>();
            this.deletedlist = new List<RASF.General.Data.Contracts_IsHold>();
        }

        public Contracts_IsHoldList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

