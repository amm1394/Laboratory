using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class ContractsEditList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Contracts_Edit>
    {
        public ContractsEditList()
        {
            this.spName = "Contracts_Edit";
            this.list = new List<RASF.General.Data.Contracts_Edit>();
            this.deletedlist = new List<RASF.General.Data.Contracts_Edit>();

        }

        public ContractsEditList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }    
}
