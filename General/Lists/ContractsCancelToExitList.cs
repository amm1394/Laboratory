using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ContractsCancelToExitList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Contracts_CancelToExit>
    {
        public ContractsCancelToExitList()
        {
            this.spName = "Contracts_CancelToExit";
            this.list = new List<RASF.General.Data.Contracts_CancelToExit>();
            this.deletedlist = new List<RASF.General.Data.Contracts_CancelToExit>();
        }

        public ContractsCancelToExitList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
