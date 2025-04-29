using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class ContractsFinancialList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Contracts_Finacial>
    {
        public ContractsFinancialList()
        {
            this.spName = "Contracts_Finacial";
            this.list = new List<RASF.General.Data.Contracts_Finacial>();
            this.deletedlist = new List<RASF.General.Data.Contracts_Finacial>();

        }

        public ContractsFinancialList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        
    }    
}
