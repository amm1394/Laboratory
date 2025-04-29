using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ContractsNotenteredintotheLaboratoryList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ContractsenteredintotheLaboratory>
    {
        public ContractsNotenteredintotheLaboratoryList()
        {
            this.spName = "ContractsNotenteredintotheLaboratory";
            this.list = new List<RASF.General.Data.ContractsenteredintotheLaboratory>();
            this.deletedlist = new List<RASF.General.Data.ContractsenteredintotheLaboratory>();
        }

        public ContractsNotenteredintotheLaboratoryList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
