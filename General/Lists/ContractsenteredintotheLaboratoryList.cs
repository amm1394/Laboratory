using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ContractsenteredintotheLaboratoryList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ContractsenteredintotheLaboratory>
    {
        public ContractsenteredintotheLaboratoryList()
        {
            this.spName = "ContractsenteredintotheLaboratory";
            this.list = new List<RASF.General.Data.ContractsenteredintotheLaboratory>();
            this.deletedlist = new List<RASF.General.Data.ContractsenteredintotheLaboratory>();
        }

        public ContractsenteredintotheLaboratoryList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
