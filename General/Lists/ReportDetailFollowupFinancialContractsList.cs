using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportDetailFollowupFinancialContractsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Contracts_IsHold>
    {
        public ReportDetailFollowupFinancialContractsList()
        {
            this.spName = "ReportDetailFollowupFinancialContracts";
            this.list = new List<RASF.General.Data.Contracts_IsHold>();
            this.deletedlist = new List<RASF.General.Data.Contracts_IsHold>();
        }

        public ReportDetailFollowupFinancialContractsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

