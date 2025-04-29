using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class DebtorCreditorCompaniesWorkFlowList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DebPayCompanies>
    {
        public DebtorCreditorCompaniesWorkFlowList()
        {
            this.spName = "DebtorCreditorCompaniesWorkFlow";
            this.list = new List<RASF.General.Data.DebPayCompanies>();
            this.deletedlist = new List<RASF.General.Data.DebPayCompanies>();
        }

        public DebtorCreditorCompaniesWorkFlowList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
