using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class DebtorCreditorCompaniesList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DebtorCreditorCompanies>
    {
        public DebtorCreditorCompaniesList()
        {
            this.spName = "DebtorCreditorCompanies";
            this.list = new List<RASF.General.Data.DebtorCreditorCompanies>();
            this.deletedlist = new List<RASF.General.Data.DebtorCreditorCompanies>();
        }

        public DebtorCreditorCompaniesList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
