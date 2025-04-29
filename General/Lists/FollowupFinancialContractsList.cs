using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class FollowupFinancialContractsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Contracts_IsHold>
    {
        public FollowupFinancialContractsList()
        {
            this.spName = "FollowupFinancialContracts";
            this.list = new List<RASF.General.Data.Contracts_IsHold>();
            this.deletedlist = new List<RASF.General.Data.Contracts_IsHold>();
        }

        public FollowupFinancialContractsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

