using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CreditreportingcompaniesList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Creditreportingcompanies>
    {
        public CreditreportingcompaniesList()
        {
            this.spName = "Creditreportingcompanies";
            this.list = new List<RASF.General.Data.Creditreportingcompanies>();
            this.deletedlist = new List<RASF.General.Data.Creditreportingcompanies>();
        }

        public CreditreportingcompaniesList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
