using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CreditCompanyWorkFlowList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CompanyWorkFlow>
    {
        public CreditCompanyWorkFlowList()
        {
            this.spName = "CompanyWorkFlow";
            this.list = new List<RASF.General.Data.CompanyWorkFlow>();
            this.deletedlist = new List<RASF.General.Data.CompanyWorkFlow>();
        }

        public CreditCompanyWorkFlowList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
